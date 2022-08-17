// See https://aka.ms/new-console-template for more information

using System;
using NBitcoin;

namespace Jesse
{
    class KeysAddresses
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++ )
            {
                Key privateKey = new Key();
                PubKey publicKey = privateKey.PubKey;
                Console.WriteLine("P2PKH: " + publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main));
                Console.WriteLine("Taproot: " + publicKey.GetAddress(ScriptPubKeyType.TaprootBIP86, Network.Main));
                Console.WriteLine("P2WPKH: " + publicKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main));
                Console.WriteLine("P2WPKH-P2SH: " + publicKey.GetAddress(ScriptPubKeyType.SegwitP2SH, Network.Main));
                Console.WriteLine("");
            }
        }
    }
}