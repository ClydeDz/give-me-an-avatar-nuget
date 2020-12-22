namespace GiveMeAnAvatar
{
    /// <summary>
    /// Use these avatar settings to customize your avatar a bit.
    /// </summary>
    public class AvatarSettings
    {
        private string _name;
        private int? _size;
        private string _extraFilter;

        /// <summary>
        /// Use these avatar settings to customize your avatar a bit.
        /// </summary>
        public AvatarSettings() { }

        /// <summary>
        /// (Optional) Some avatars display user initials or even the full name and if this setting isn't supplied, 
        /// the program randomly decides a user initial. Feel free to supply a value if you need to
        /// override this value.
        /// </summary> 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// (Optional) If this setting isn't supplied, the program will randomly decide an avatar size of the aspect 
        /// ratio 1:1, i.e., a square avatar. If you'd like your avatar size to be of a particular size, 
        /// supply a number to this setting.
        /// </summary>
        public int? Size
        {
            get { return _size; }
            set { _size = value; }
        }

        internal string ExtraFilter
        {
            get { return _extraFilter; }
            set { _extraFilter = value; }
        }
    }
}
