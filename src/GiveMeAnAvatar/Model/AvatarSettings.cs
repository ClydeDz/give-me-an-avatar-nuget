namespace GiveMeAnAvatar
{
    public class AvatarSettings
    {
        private string _name;
        private int? _size;
        private string _extraFilter;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
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
