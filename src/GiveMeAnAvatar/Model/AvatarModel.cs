namespace GiveMeAnAvatar.Model
{
    internal class AvatarModel
    {
        private string _key;
        private string _url;

        internal AvatarModel(string key, string url)
        {
            Key = key;
            URL = url;
        }

        internal string Key
        {
            get { return _key; }
            set { _key = value; }
        } 
        internal string URL
        {
            get { return _url; }
            set { _url = value; }
        }
    }
}
