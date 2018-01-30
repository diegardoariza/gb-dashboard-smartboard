using System;
using System.IO;
using Amazon.S3;
using Amazon.S3.Model;
using System.Configuration;

namespace GBDashboard.Utils
{
    internal static class AmazonAWSS3Manager
    {
        static string bucketName = ConfigurationManager.AppSettings["bucketName"].ToString();
        static string accessKeyID = ConfigurationManager.AppSettings["accessKeyID"].ToString();
        static string secretAccessKey ConfigurationManager.AppSettings["secretAccessKey"].ToString();
        static IAmazonS3 s3Client;

        internal static void PostFile(String filePath, String s3File, String contentType)
        {
            s3Client = new AmazonS3Client(accessKeyID, secretAccessKey, Amazon.RegionEndpoint.USEast1);
            try
            {
                PutObjectRequest request = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = accessKeyID,
                    FilePath = filePath
                };

                PutObjectResponse response = s3Client.PutObject(request);
            }
            catch (AmazonS3Exception amazonS3Exception)
            {
                if (amazonS3Exception.ErrorCode != null &&
                    (amazonS3Exception.ErrorCode.Equals("InvalidAccessKeyId")
                    ||
                    amazonS3Exception.ErrorCode.Equals("InvalidSecurity")))
                {
                    Console.WriteLine("Check the provided AWS Credentials.");
                    Console.WriteLine(
                        "For service sign up go to http://aws.amazon.com/s3");
                }
                else
                {
                    Console.WriteLine(
                        "Error occurred. Message:'{0}' when writing an object"
                        , amazonS3Exception.Message);
                }
            }
        }

        internal static void DownloadFile(String keyName, String downloadPath)
        {
            try
            {
                using (s3Client = new AmazonS3Client(accessKeyID, secretAccessKey, Amazon.RegionEndpoint.USEast1);
                {
                    GetObjectRequest request = new GetObjectRequest
                    {
                        BucketName = bucketName,
                        Key = keyName
                    };

                    using (GetObjectResponse response = s3Client.GetObject(request))
                    {
                        string dest = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), keyName);
                        if (!File.Exists(downloadPath))
                        {
                            response.WriteResponseStreamToFile(downloadPath);
                        }
                    }
                }
            }
            catch (AmazonS3Exception s3Exception)
            {
                Console.WriteLine(s3Exception.Message,
                                  s3Exception.InnerException);
            }
        }
    }
}
