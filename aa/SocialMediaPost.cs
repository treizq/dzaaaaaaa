using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class SocialMediaPost
    {
        public int Id { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string Message { get; set; }

        public static SocialMediaPost operator +(SocialMediaPost post, int likesToAdd)
        {
            post.Likes += likesToAdd;
            return post;
        }

        public static SocialMediaPost operator -(SocialMediaPost post, int dislikesToAdd)
        {
            post.Dislikes += dislikesToAdd;
            return post;
        }

        public static SocialMediaPost operator ++(SocialMediaPost post)
        {
            post.Likes++;
            return post;
        }

        public static SocialMediaPost operator --(SocialMediaPost post)
        {
            post.Dislikes++;
            return post;
        }
    }
    public static class Recommendations
    {
        public static bool IsRecommended(SocialMediaPost post)
        {
            return post.Likes >= 2 * post.Dislikes;
        }
    }
}
