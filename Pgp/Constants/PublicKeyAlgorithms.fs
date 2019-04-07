﻿module Constants.PublicKeyAlgorithms

open System.IO

type PublicKeyAlgorithm = UnknownPublicKeyAlgorithm
                        | RsaEncryptOrSign
                        | RsaEncryptOnly
                        | RsaSignOnly
                        | ElgamalEncryptOnly
                        | DsaSignOnly
                        | ReservedEllipticCurve
                        | ReservedEcdsa
                        | ReservedFormerlyElgamalEncryptOrSign
                        | ReservedDiffieHellman
                        | PrivateOrExperimentalPublicKeyAlgorithm

                        
let read (input : Stream) : PublicKeyAlgorithm =
    match (input.ReadByte()) with
        | 1 -> RsaEncryptOrSign
        | 2 -> RsaEncryptOnly
        | 3 -> RsaSignOnly
        | 16 -> ElgamalEncryptOnly
        | 17 -> DsaSignOnly
        | 18 -> ReservedEllipticCurve
        | 19 -> ReservedEcdsa
        | 20 -> ReservedFormerlyElgamalEncryptOrSign
        | 21 -> ReservedDiffieHellman
        | octet when octet >= 100 && octet <= 110 -> PrivateOrExperimentalPublicKeyAlgorithm
        | _ -> UnknownPublicKeyAlgorithm
