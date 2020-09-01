using System;
using System.Collections.Generic;
using System.Text;

namespace SecurePrivacy.Common.Models
{
    public class BookModel
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public Guid AccessKey { get; set; }
    }
}
