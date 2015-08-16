using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public interface ICommentable
    {
        void AddComment(string comment);
        void DeleteComment();
        void PrintComments();
    }
}
