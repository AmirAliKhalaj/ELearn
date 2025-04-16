using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearn.dataLayer.Entities
{
    public class Episode
    {
        public int EpisodeTitle { get; set; }
        public string videoName { get; set; }
        public string Time { get; set; }
        public string Title { get; set; }
        public bool IsFree { get; set; } = false;
        public DateTimeOffset PublishDate { get; set; }
        #region Relations
        public CourseSeason CourseSeason { get; set; }
        #endregion

    }
}
