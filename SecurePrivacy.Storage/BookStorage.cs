using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecurePrivacy.Domain;

namespace SecurePrivacy.Storage
{
    public static class BookStorage<T>
    {
        public static List<T> bookStorage = new List<T>();
    }
}
