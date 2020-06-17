namespace TeamSpeak3QueryApi.Net.Specialized.Responses
{
    public class GetChannelGroupListInfo : Response
    {
        [QuerySerialize("cgid")]
        public int Id;

        [QuerySerialize("name")]
        public string Name;

        [QuerySerialize("type")]
        public ChannelGroupType ChannelGroupType;

        [QuerySerialize("iconid")]
        public int IconID;

        [QuerySerialize("savedb")]
        public int SaveDB;

        public override string ToString()
        {
            return $"{Name} ({Id})";
        }
    }
}
