using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearnDataLayer.Entities
{
    public class Episode
    {
        public int EpisodeId { get; set; }
        public int EpisodeTitle { get; set; }
        public string videoName { get; set; }
        public string Time { get; set; }
        public string Title { get; set; }
        public bool IsFree { get; set; } = false;
        public bool IsDeleted { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        #region Relations
        public CourseSeason CourseSeason { get; set; }
        #endregion
    }
}
