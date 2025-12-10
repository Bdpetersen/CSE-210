public class Video
    {
        public string _title;
        public string _author;
        public int _length; // In seconds
        private List<Comment> _comments = new List<Comment>();

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
        }

        public void AddComment(Comment newComment)
        {
            _comments.Add(newComment);
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }

        // Helper method to let the main program access the comments for display
        public List<Comment> GetComments()
        {
            return _comments;
        }
    }