using Facebook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Viva.Facebook
{
    public class FacebookProvider
    {
        public dynamic GetToken()
        {
            var fb = new FacebookClient();
            dynamic result = fb.Get("oauth/access_token", new
            {
                client_id = ApplicationConfiguration.FacebookAppId,
                client_secret = ApplicationConfiguration.FacebookClientSecret,
                grant_type = "client_credentials"
            });
            return result;
        }

        //public void GetFeed()
        //{
        //    //https://graph.facebook.com/search?q=scottmayfield&type=user
        //    //https://graph.facebook.com/wikipedia/posts?access_token={0}

        //    var client = new FacebookClient(ApplicationConfiguration.FacebookAppToken);
        //    client.Get()
        //}

        //public void Post(string msg, string token)
        //{
        //    var fb = new FacebookClient(token);
        //    fb.PostCompleted += (o, e) =>
        //    {
        //        if (e.Error == null)
        //        {
        //            var result = (IDictionary<string, object>)e.GetResultData();
        //            var newPostId = result["id"].ToString();
        //        }
        //    };

        //    var parameters = new Dictionary<string, object>();
        //    parameters["message"] = msg;
        //    fb.PostAsync("me/feed", parameters);
        //}

        //public void DeletePreviousPost(string postId, string token)
        //{
        //    var fb = new FacebookClient(token);
        //    fb.DeleteCompleted += (o, e) =>
        //    {
        //        if (e.Cancelled || e.Error != null)
        //        {
        //            return;
        //        }

        //        var result = e.GetResultData();
        //    };
        //    fb.DeleteAsync(postId);
        //}

        //public void PostImageWithMediaObject(string filename)
        //{
        //    var fb = new FacebookClient("access_token");
        //    Stream attachment = new StreamReader(filename);
        //    fb.PostCompleted += (o, e) =>
        //    {
        //        attachment.Dispose();

        //        if (e.Cancelled || e.Error != null)
        //        {
        //            return;
        //        }

        //        var result = e.GetResultData();
        //    };

        //    var parameters = new Dictionary<string, object>();
        //    parameters["message"] = "upload using Facebook SDK for .NET";
        //    parameters["file"] = new FacebookMediaStream
        //                        {
        //                            ContentType = "image/jpeg",
        //                            FileName = "image.jpg"
        //                        }.SetValue(attachment);
        //    fb.PostAsync("me/photos", parameters);
        //}

        //public static string UploadPictureToWall(string id, string accessToken, string filePath)
        //{
        //    var mediaObject = new FacebookMediaObject
        //    {
        //        FileName = Path.GetFileName(filePath),
        //        ContentType = "image/jpeg" // TODO: detect content type from file...
        //    };

        //    mediaObject.SetValue(System.IO.File.ReadAllBytes(filePath));

        //    try
        //    {
        //        var fb = new FacebookClient(accessToken);

        //        var result = (IDictionary<string, object>)fb.Post(id + "/photos", new Dictionary<string, object>
        //                           {
        //                               { "source", mediaObject },
        //                               { "message","photo" }
        //                           });

        //        var postId = (string)result["id"];

        //        //Console.WriteLine("Post Id: {0}", postId);

        //        //// Note: This json result is not the orginal json string as returned by Facebook.
        //        //Console.WriteLine("Json: {0}", result.ToString());

        //        return postId;
        //    }
        //    catch (FacebookApiException ex)
        //    {
        //        // Note: make sure to handle this exception.
        //        throw;
        //    }
        //}
    }
}
