﻿namespace OpenChain.Ledger
{
    public class SignatureEvidence
    {
        public SignatureEvidence(ByteString publicKey, ByteString signature)
        {
            this.PublicKey = publicKey;
            this.Signature = signature;
        }

        public ByteString PublicKey { get; private set; }

        public ByteString Signature { get; private set; }
    }
}
