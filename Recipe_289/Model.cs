using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Recipe_289 {

    public class Post {
        public int PostId { get; set; }
        public string Message { get; set; }
        public DateTime SentTime { get; set; }

    }
}
