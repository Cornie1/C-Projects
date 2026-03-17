using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
namespace BirdWatcher.Services
{
    public class BlobService
    {
        //our singleton object for the blob service
        //we make it readonly, so it cannot be modified once instantiated
        private readonly BlobServiceClient blobServiceClient;
        private const string containerName = "images";

        //CONSTRUCTOR ==used to initialise a class
        public BlobService(string connectionString)
        {
            //Option 1
            blobServiceClient = new BlobServiceClient(connectionString);
            //Option 2
            blobServiceClient = new(connectionString);
        }
        //async ==it can run in PARALLEL( the app doesnt have to wait for the method to finish / non-locking)
        //Task type is used when using async, with return type in <carats>
        //it expects an IFormFile (which is what an html form provides when uploading a file)
        public async Task<string> UploadImageAsync(IFormFile imageToUpload)
        { //open the "folder/container" that we want to store the image in
            var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            //as a safety check we make sure the containter exists
            await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);
            var blobClient = containerClient.GetBlobClient(Guid.NewGuid().ToString() + Path.GetExtension(imageToUpload.FileName));
            //in order to upload a file, we need to turn it into a stream of data
            using var stream = imageToUpload.OpenReadStream();
            //upload time
            await blobClient.UploadAsync(stream);
            //finally, return uri( basically URL) so we can sotre it in the database
            return blobClient.Uri.ToString();
        }
    }
}
