using System;

public interface IKeyPair : IJsonable
{
   string Key { get; set; }
   string Value { get; set; }
}
