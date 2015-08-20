using System;

namespace SchoolClasses
{
    public class GenericObj : ICommentable
    {
        private string comment;

        public GenericObj()
        {

        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
    }
}
