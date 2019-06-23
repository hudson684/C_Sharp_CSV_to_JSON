public class KeyPair : IKeyPair , IJsonable
{
   private string _key;
   private string _value;
   public KeyPair(string Key, string Value)
   {
      _key = Key;
      _value = Value;
   }
   public string Key{
      get { return _key; }
      set { _key = value; }
   }
   public string Value{
      get { return _value; }
      set { _value = value; }
   }

   public string ToJson()
   {
      return "{\"key\":\"" + _key + "\",\"value\":\"" + _value +"\"}";
   }

}