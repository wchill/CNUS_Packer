namespace CNUS_packer.utils
{
    public class AppXMLInfo
    {
        private const int version = 0;
        public long osVersion { get; set; }
        public long titleID { get; set; }
        public short titleVersion { get; set; }
        public uint sdkVersion { get; set; }
        public uint appType { get; set; }
        public short groupID { get; set; }
        public byte[] osMask = new byte[32];
        public long common_id { get; set; }

        public override string ToString()
        {
            return "AppXMLInfo [version=" + version + ", OSVersion=" + osVersion + ", titleID=" + titleID
                + ", titleVersion=" + titleVersion + ", SDKVersion=" + sdkVersion + ", appType=" + appType
                + ", groupID=" + groupID + ", OSMask=" + Utils.ByteArrayToHexString(osMask) + ", common_id=" + common_id + "]";
        }
    }
}
