using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RunGameTest.Models
{
    public class BlobStorageServices
    {
        // Update the Batch and Storage account credential strings below with the values unique to your accounts.
        //    // These are used when constructing connection strings for the Batch and Storage client objects.

        //    // Batch account credentials
           private const string BatchAccountName = "backend1";
           private const string BatchAccountKey = "3vluRa8HxrRoByBIgJx/J2OhMlW+Zp0Ydn0nH3JftgpMfY4RDFEG7i96mKf1G4Sig9Bg4lqa9h9zDYKV8iCK1Q==";
           private const string BatchAccountUrl = "https://backend1.canadacentral.batch.azure.com";

        //    // Storage account credentials
           private const string StorageAccountName = "jobgame";
           private const string StorageAccountKey = "rn4rbw2ZOobmlXmRlt2nrWA5Wk5/zGffhBvEmUKzFB1EvdotWg+g9YtyIFsElTMJRp9LYx00YvFm2xIrpPmt0g==";

        //    // Batch resource settings
           private const string PoolId = "DotNetQuickstartPool";
           private const string JobId = "DotNetQuickstartJob";
           private const int PoolNodeCount = 2;
           private const string PoolVMSize = "STANDARD_A1_v2";

          // private static void CreateBatchPool(BatchClient batchClient, VirtualMachineConfiguration vmConfiguration)
          // {
              // try
            //    {
            //       CloudPool pool = batchClient.PoolOperations.CreatePool(
             //           poolId: PoolId,
             //           targetDedicatedComputeNodes: PoolNodeCount,
              //         virtualMachineSize: PoolVMSize,
             //          virtualMachineConfiguration: vmConfiguration);

             //       pool.Commit();
             //   }
            //    catch (BatchException be)
              //  {
        //            // Accept the specific error code PoolExists as that is expected if the pool already exists
                  //  if (be.RequestInformation?.BatchError?.Code == BatchErrorCodeStrings.PoolExists)
                 //   {
                 //       Console.WriteLine("The pool {0} already existed when we tried to create it", PoolId);
               //    }
               //     else
                //   {
                  //     throw; // Any other exception is unexpected
              //     }
          //     }
           // }

        //    private static VirtualMachineConfiguration CreateVirtualMachineConfiguration(ImageReference imageReference)
        //    {
        //        return new VirtualMachineConfiguration(
        //            imageReference: imageReference,
        //            nodeAgentSkuId: "batch.node.windows amd64");
        //    }

        //    private static ImageReference CreateImageReference()
        //    {
        //        return new ImageReference(
        //            publisher: "MicrosoftWindowsServer",
        //            offer: "WindowsServer",
        //            sku: "2016-datacenter-smalldisk",
        //            version: "latest");
        //    }

        //    /// <summary>
        //    /// Creates a blob client
        //    /// </summary>
        //    /// <param name="storageAccountName">The name of the Storage Account</param>
        //    /// <param name="storageAccountKey">The key of the Storage Account</param>
        //    /// <returns></returns>
        //    private static CloudBlobClient CreateCloudBlobClient(string storageAccountName, string storageAccountKey)
        //    {
        //        // Construct the Storage account connection string
        //        string storageConnectionString =
        //            $"DefaultEndpointsProtocol=https;AccountName={storageAccountName};AccountKey={storageAccountKey}";

        //        // Retrieve the storage account
        //        CloudStorageAccount storageAccount = CloudStorageAccount.Parse(storageConnectionString);

        //        // Create the blob client
        //        CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
        //        return blobClient;
        //    }


        //    /// <summary>
        //    /// Uploads the specified file to the specified Blob container.
        //    /// </summary>
        //    /// <param name="blobClient">A <see cref="CloudBlobClient"/>.</param>
        //    /// <param name="containerName">The name of the blob storage container to which the file should be uploaded.</param>
        //    /// <param name="filePath">The full path to the file to upload to Storage.</param>
        //    /// <returns>A ResourceFile instance representing the file within blob storage.</returns>
        //    private static ResourceFile UploadFileToContainer(CloudBlobClient blobClient, string containerName, string filePath)
        //    {
        //        Console.WriteLine("Uploading file {0} to container [{1}]...", filePath, containerName);

        //        string blobName = Path.GetFileName(filePath);

        //        filePath = Path.Combine(Environment.CurrentDirectory, filePath);

        //        CloudBlobContainer container = blobClient.GetContainerReference(containerName);
        //        CloudBlockBlob blobData = container.GetBlockBlobReference(blobName);
        //        blobData.UploadFromFileAsync(filePath).Wait();

        //        // Set the expiry time and permissions for the blob shared access signature. 
        //        // In this case, no start time is specified, so the shared access signature 
        //        // becomes valid immediately
        //        SharedAccessBlobPolicy sasConstraints = new SharedAccessBlobPolicy
        //        {
        //            SharedAccessExpiryTime = DateTime.UtcNow.AddHours(2),
        //            Permissions = SharedAccessBlobPermissions.Read
        //        };

        //        // Construct the SAS URL for blob
        //        string sasBlobToken = blobData.GetSharedAccessSignature(sasConstraints);
        //        string blobSasUri = String.Format("{0}{1}", blobData.Uri, sasBlobToken);

        //        return ResourceFile.FromUrl(blobSasUri, filePath);
        //    }


    }
}
    
