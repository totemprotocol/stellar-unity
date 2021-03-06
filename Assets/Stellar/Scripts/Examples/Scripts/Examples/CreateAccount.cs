﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using stellar_dotnet_sdk;
using stellar_dotnet_sdk.responses;
using stellar_dotnet_sdk.requests;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using UStellar.Core;


using UnityEngine.UI;

namespace UStellar.Examples
{
    /// <summary>
    /// This example let you 'create' a new account.
    /// When you run the example, you will get the public and secret keys.
    /// For this account to exist in the Stellar Network you need to send at least 1 lumen to the PublicKey address.
    /// </summary>
    public class CreateAccount : Example
    {
        public override int id
        {
            get
            {
                return 0;
            }
        }

        public override string title
        {
            get
            {
                return "CREATE ACCOUNT";
            }
        }

        public override string description
        {
            get
            {
                return "This example will generate a KeyPair with a random public address and a secret seed.";
            }
        }

        public override void Run()
        {
            base.Run();
        }

        private void GenerateAccountKeyPair()
        {
            //Create new random Keypair
            KeyPair newKeyPair = KeyPair.Random();

            //Log it
            Log(string.Concat("Public: ", newKeyPair.AccountId), 0);
            Log(string.Concat("Secret: ", newKeyPair.SecretSeed));
        }
    }
}