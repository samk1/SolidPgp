namespace Pgp.Tests

module TestData =
    let Encrypted15Bytes = [| 0xeeuy; 0x61uy; 0xc3uy; 0x5cuy; 0x67uy; 0x02uy; 0xa4uy; 0xb3uy; 0x00uy; 0xc4uy; 0x72uy; 0xd1uy; 0x42uy; 0xbcuy; 0xa3uy |]
    let Encrypted16Bytes = [| 0xeeuy; 0x61uy; 0xc3uy; 0x5cuy; 0x67uy; 0x02uy; 0xa4uy; 0xb3uy; 0x00uy; 0xc4uy; 0x72uy; 0xd1uy; 0x42uy; 0xbcuy; 0xa3uy; 0xa6uy |]
    let Encrypted17Bytes = [| 0xeeuy; 0x61uy; 0xc3uy; 0x5cuy; 0x67uy; 0x02uy; 0xa4uy; 0xb3uy; 0x00uy; 0xc4uy; 0x72uy; 0xd1uy; 0x42uy; 0xbcuy; 0xa3uy; 0xa6uy; 0xd5uy |]
    let Encrypted1000Bytes = 
        [| 
            0xeeuy; 0x61uy; 0xc3uy; 0x5cuy; 0x67uy; 0x02uy; 0xa4uy; 0xb3uy; 0x00uy; 0xc4uy; 0x72uy; 0xd1uy; 0x42uy; 0xbcuy; 0xa3uy; 0xa6uy
            0xd5uy; 0x78uy; 0xf1uy; 0xa6uy; 0x41uy; 0xb1uy; 0x06uy; 0x97uy; 0xdduy; 0x41uy; 0x42uy; 0x03uy; 0x35uy; 0x97uy; 0x13uy; 0xf7uy
            0xc6uy; 0x5auy; 0xb8uy; 0xbauy; 0xefuy; 0x87uy; 0x3fuy; 0x66uy; 0xa4uy; 0xc1uy; 0xa0uy; 0x29uy; 0x43uy; 0xd2uy; 0x5cuy; 0xa3uy
            0xf9uy; 0x53uy; 0xb0uy; 0xb4uy; 0x20uy; 0x26uy; 0x44uy; 0xe5uy; 0xecuy; 0xbbuy; 0x50uy; 0x4fuy; 0x9fuy; 0xf7uy; 0xffuy; 0x44uy
            0x55uy; 0x96uy; 0x3auy; 0xebuy; 0xf3uy; 0x2buy; 0x82uy; 0x24uy; 0xb5uy; 0xbeuy; 0xd1uy; 0x08uy; 0xb2uy; 0x42uy; 0x45uy; 0x9euy
            0x37uy; 0x1buy; 0x84uy; 0x5fuy; 0xcbuy; 0xa1uy; 0x63uy; 0xb0uy; 0xe4uy; 0x32uy; 0xb8uy; 0x24uy; 0xccuy; 0x7buy; 0x65uy; 0x30uy
            0x29uy; 0x8duy; 0x99uy; 0x55uy; 0x85uy; 0x3duy; 0xa4uy; 0x33uy; 0x7auy; 0xa9uy; 0x7duy; 0xe9uy; 0x24uy; 0x54uy; 0xf2uy; 0xe7uy
            0xd1uy; 0x79uy; 0x24uy; 0x39uy; 0x77uy; 0x17uy; 0x04uy; 0xb2uy; 0xf6uy; 0x50uy; 0xa8uy; 0x65uy; 0xd4uy; 0xd8uy; 0x45uy; 0x93uy
            0x46uy; 0x22uy; 0x1buy; 0xc8uy; 0xafuy; 0x0euy; 0x89uy; 0x9euy; 0x76uy; 0x7auy; 0xdauy; 0xfcuy; 0xa5uy; 0x96uy; 0x20uy; 0x03uy
            0xf5uy; 0x5fuy; 0x02uy; 0x94uy; 0xb0uy; 0x0cuy; 0x2fuy; 0x3euy; 0x50uy; 0xbcuy; 0x5fuy; 0xbbuy; 0x76uy; 0x81uy; 0xe4uy; 0x03uy
            0xabuy; 0xbbuy; 0xc6uy; 0xd6uy; 0x9buy; 0x30uy; 0x1duy; 0xf7uy; 0xffuy; 0x5cuy; 0x00uy; 0x73uy; 0x47uy; 0x22uy; 0x0fuy; 0x70uy
            0x77uy; 0x54uy; 0xc0uy; 0x9auy; 0xdfuy; 0xc2uy; 0x70uy; 0xd4uy; 0x37uy; 0x1auy; 0xbduy; 0x6cuy; 0x04uy; 0x0auy; 0x4cuy; 0x32uy
            0xc6uy; 0x4auy; 0x4auy; 0x0cuy; 0x55uy; 0xbcuy; 0x5duy; 0x27uy; 0x8euy; 0x7buy; 0x35uy; 0xcauy; 0x4cuy; 0xeauy; 0x49uy; 0x49uy
            0x37uy; 0x7fuy; 0x4euy; 0xcbuy; 0x6auy; 0x5duy; 0x2fuy; 0xb0uy; 0x56uy; 0x0auy; 0x95uy; 0x22uy; 0x6cuy; 0xc5uy; 0x6duy; 0x59uy
            0xe2uy; 0x2buy; 0x17uy; 0x79uy; 0xb3uy; 0x52uy; 0x44uy; 0x6cuy; 0xf6uy; 0x4duy; 0x67uy; 0x2duy; 0xecuy; 0xf5uy; 0x8fuy; 0xccuy
            0x85uy; 0x27uy; 0x91uy; 0x0auy; 0x8buy; 0x5buy; 0x68uy; 0xffuy; 0x29uy; 0x13uy; 0xb7uy; 0x9buy; 0x42uy; 0x1cuy; 0xafuy; 0xeduy
            0x84uy; 0xd9uy; 0x44uy; 0x5fuy; 0x8duy; 0x1fuy; 0x26uy; 0x42uy; 0xaeuy; 0xa6uy; 0xd6uy; 0xf8uy; 0x23uy; 0xb4uy; 0x8cuy; 0x93uy
            0xe4uy; 0x12uy; 0xcfuy; 0x3auy; 0x5buy; 0x69uy; 0x4fuy; 0x34uy; 0x65uy; 0x6cuy; 0xc4uy; 0x89uy; 0xd0uy; 0xa0uy; 0x76uy; 0xf1uy
            0xbauy; 0xa2uy; 0x70uy; 0x72uy; 0x02uy; 0xc7uy; 0x88uy; 0x7cuy; 0x7buy; 0xf2uy; 0xd8uy; 0x02uy; 0x60uy; 0x4auy; 0xd9uy; 0xeauy
            0xa8uy; 0x94uy; 0xd6uy; 0xa4uy; 0x93uy; 0x74uy; 0x9auy; 0x70uy; 0x7auy; 0xb3uy; 0xa0uy; 0x8buy; 0x79uy; 0x33uy; 0xc7uy; 0x41uy
            0xc3uy; 0xf9uy; 0x51uy; 0x08uy; 0x47uy; 0x75uy; 0x4duy; 0x6fuy; 0x08uy; 0x0euy; 0xffuy; 0x5euy; 0xabuy; 0x1duy; 0xa9uy; 0xa2uy
            0xaauy; 0x6cuy; 0x47uy; 0xdeuy; 0x23uy; 0xafuy; 0xa3uy; 0x0cuy; 0x0duy; 0x01uy; 0x8cuy; 0x18uy; 0xd2uy; 0xa9uy; 0xaauy; 0x09uy
            0xebuy; 0xb8uy; 0x10uy; 0x26uy; 0x12uy; 0x0buy; 0x6euy; 0x35uy; 0x36uy; 0x70uy; 0xa9uy; 0x0auy; 0xb4uy; 0x6cuy; 0xecuy; 0xb4uy
            0xcfuy; 0x31uy; 0xf0uy; 0xfauy; 0xbeuy; 0x24uy; 0x86uy; 0x10uy; 0xaduy; 0x18uy; 0x8fuy; 0xdauy; 0x8buy; 0x48uy; 0x54uy; 0xdfuy
            0xa5uy; 0xa0uy; 0x74uy; 0x34uy; 0xa8uy; 0xceuy; 0x09uy; 0x9fuy; 0x3euy; 0x55uy; 0x9fuy; 0x4duy; 0x5cuy; 0xa6uy; 0x0cuy; 0xfeuy
            0x0euy; 0x8duy; 0x3duy; 0xdduy; 0xe8uy; 0xb5uy; 0xf8uy; 0xd2uy; 0xb5uy; 0x7fuy; 0xd6uy; 0x5fuy; 0xe9uy; 0x62uy; 0x0duy; 0x04uy
            0xc0uy; 0x16uy; 0x1euy; 0xe7uy; 0x5buy; 0x1fuy; 0x23uy; 0x45uy; 0xf7uy; 0xd9uy; 0xe2uy; 0x0cuy; 0x36uy; 0xfeuy; 0xf1uy; 0xd7uy
            0x05uy; 0xb5uy; 0x5auy; 0x81uy; 0x8buy; 0x33uy; 0x6buy; 0xfeuy; 0x46uy; 0xe1uy; 0x5cuy; 0xa8uy; 0x58uy; 0x49uy; 0x94uy; 0x78uy
            0x0cuy; 0xa7uy; 0x76uy; 0xd2uy; 0xacuy; 0x18uy; 0xb5uy; 0x2euy; 0x14uy; 0x1euy; 0x14uy; 0x24uy; 0x10uy; 0x08uy; 0x22uy; 0x5buy
            0xa1uy; 0x5cuy; 0xb5uy; 0xf6uy; 0xc8uy; 0xaduy; 0x0fuy; 0x21uy; 0xbeuy; 0x77uy; 0x11uy; 0xbfuy; 0x10uy; 0x60uy; 0x3euy; 0xdeuy
            0x9fuy; 0x7duy; 0xfcuy; 0x05uy; 0x17uy; 0xa8uy; 0x86uy; 0xfauy; 0x09uy; 0x99uy; 0xe2uy; 0xe5uy; 0x50uy; 0x46uy; 0xb0uy; 0x0duy
            0x7auy; 0xc0uy; 0x4cuy; 0x17uy; 0x69uy; 0x97uy; 0xf7uy; 0x12uy; 0xb4uy; 0x1fuy; 0x01uy; 0xf8uy; 0x89uy; 0xecuy; 0x86uy; 0xaeuy
            0x8auy; 0xf4uy; 0xc9uy; 0x91uy; 0xa7uy; 0x22uy; 0x74uy; 0x2auy; 0x11uy; 0xccuy; 0x1buy; 0x76uy; 0xe4uy; 0xb7uy; 0x9auy; 0xe0uy
            0xfduy; 0xb2uy; 0xd7uy; 0xc1uy; 0xfduy; 0xe0uy; 0x3cuy; 0x60uy; 0xeduy; 0x9euy; 0xf4uy; 0xc0uy; 0x23uy; 0x0auy; 0x1fuy; 0xc9uy
            0xa8uy; 0xd2uy; 0xfcuy; 0x3duy; 0xdeuy; 0x52uy; 0xbbuy; 0x7fuy; 0x0auy; 0x52uy; 0x4fuy; 0xf8uy; 0x79uy; 0x3fuy; 0x03uy; 0x14uy
            0x87uy; 0x55uy; 0xa2uy; 0x26uy; 0x7duy; 0x87uy; 0x82uy; 0xd2uy; 0x0euy; 0x0fuy; 0x49uy; 0x3fuy; 0xf5uy; 0xd2uy; 0xefuy; 0xb3uy
            0xbcuy; 0x77uy; 0x74uy; 0x27uy; 0xaeuy; 0x22uy; 0x57uy; 0x88uy; 0xaduy; 0x44uy; 0x64uy; 0xd1uy; 0x2fuy; 0xe5uy; 0xe8uy; 0xfduy
            0x4auy; 0x35uy; 0xeauy; 0xe4uy; 0x50uy; 0x90uy; 0xf3uy; 0x8fuy; 0xf3uy; 0xabuy; 0x88uy; 0xc3uy; 0x70uy; 0x08uy; 0xc4uy; 0xf3uy
            0x2duy; 0xa9uy; 0x0buy; 0xf0uy; 0xa3uy; 0xecuy; 0x43uy; 0x58uy; 0xa5uy; 0x6fuy; 0x37uy; 0x37uy; 0x3euy; 0xc5uy; 0xdcuy; 0xe2uy
            0x84uy; 0x7cuy; 0x19uy; 0xf0uy; 0xf4uy; 0x20uy; 0x1fuy; 0x21uy; 0x65uy; 0x9euy; 0xe9uy; 0xceuy; 0x32uy; 0xe9uy; 0x24uy; 0x88uy
            0x4euy; 0x05uy; 0x94uy; 0x0duy; 0xccuy; 0x92uy; 0x67uy; 0x0fuy; 0xfeuy; 0xd6uy; 0xe6uy; 0x89uy; 0xc4uy; 0x2auy; 0x57uy; 0xe9uy
            0x40uy; 0xcbuy; 0xc4uy; 0x48uy; 0x0cuy; 0x2buy; 0x8cuy; 0xa7uy; 0xf7uy; 0x0cuy; 0x93uy; 0xb3uy; 0xcduy; 0x01uy; 0x6duy; 0xa1uy
            0xacuy; 0x74uy; 0x89uy; 0x4buy; 0x71uy; 0x60uy; 0x90uy; 0xaeuy; 0xa8uy; 0xa6uy; 0x83uy; 0xb9uy; 0x95uy; 0xb7uy; 0xd6uy; 0xcduy
            0xdauy; 0x02uy; 0x27uy; 0x2euy; 0x85uy; 0xbauy; 0x4buy; 0x83uy; 0xfeuy; 0x33uy; 0xe8uy; 0x86uy; 0x6duy; 0xd0uy; 0x3buy; 0x98uy
            0x0euy; 0x02uy; 0x25uy; 0xe2uy; 0xc0uy; 0x84uy; 0xd5uy; 0x88uy; 0x18uy; 0xa6uy; 0x6euy; 0x75uy; 0x86uy; 0xc1uy; 0x4fuy; 0x1euy
            0x89uy; 0x8auy; 0xb5uy; 0x8fuy; 0x9duy; 0x63uy; 0x12uy; 0xbduy; 0xacuy; 0xa7uy; 0x60uy; 0x46uy; 0x01uy; 0xb8uy; 0xb5uy; 0x69uy
            0x3fuy; 0xacuy; 0x00uy; 0xd6uy; 0x92uy; 0xd3uy; 0xb9uy; 0x76uy; 0x7fuy; 0xc7uy; 0x7fuy; 0x9auy; 0xeeuy; 0x45uy; 0x30uy; 0x58uy
            0x44uy; 0x57uy; 0x45uy; 0xf8uy; 0xfbuy; 0xa9uy; 0xd3uy; 0x8euy; 0x6auy; 0x72uy; 0x1auy; 0xf9uy; 0xdcuy; 0xf8uy; 0x54uy; 0x2euy
            0x9cuy; 0x28uy; 0xf4uy; 0xa1uy; 0xeduy; 0xd7uy; 0xbcuy; 0x02uy; 0x3auy; 0x1fuy; 0x0buy; 0x83uy; 0x03uy; 0x6buy; 0x1buy; 0xa4uy
            0x24uy; 0xd6uy; 0xe6uy; 0xb2uy; 0xe4uy; 0x23uy; 0xebuy; 0x34uy; 0x98uy; 0xbauy; 0x5buy; 0xa4uy; 0xfbuy; 0x79uy; 0x22uy; 0xb4uy
            0xc6uy; 0x56uy; 0x1euy; 0x16uy; 0x44uy; 0x3cuy; 0x8fuy; 0x16uy; 0xffuy; 0x62uy; 0x13uy; 0x38uy; 0xb1uy; 0x99uy; 0x81uy; 0x61uy
            0x53uy; 0x8fuy; 0x7fuy; 0x0euy; 0x67uy; 0xe9uy; 0x5euy; 0x0auy; 0x23uy; 0x77uy; 0xb8uy; 0x7auy; 0x3fuy; 0x5duy; 0x0buy; 0x74uy
            0xdcuy; 0x87uy; 0x23uy; 0x0auy; 0xbeuy; 0x0cuy; 0xc5uy; 0xc0uy; 0x5fuy; 0x31uy; 0xa3uy; 0xe2uy; 0xbcuy; 0x3euy; 0x19uy; 0x8auy
            0x75uy; 0x14uy; 0xc0uy; 0xd3uy; 0x37uy; 0x09uy; 0xa2uy; 0x17uy; 0xf5uy; 0xc6uy; 0x86uy; 0xf9uy; 0xf6uy; 0x73uy; 0x92uy; 0xdcuy
            0x98uy; 0xdfuy; 0x87uy; 0x19uy; 0x03uy; 0x13uy; 0x45uy; 0xbfuy; 0xb1uy; 0x02uy; 0xdeuy; 0x09uy; 0x34uy; 0x0cuy; 0xb5uy; 0x21uy
            0xecuy; 0x8auy; 0x54uy; 0x6euy; 0xa5uy; 0x2cuy; 0xc2uy; 0x80uy; 0x71uy; 0xb7uy; 0x61uy; 0x61uy; 0xe2uy; 0xb7uy; 0xbbuy; 0xe4uy
            0x5buy; 0x19uy; 0xaduy; 0x0auy; 0xbduy; 0xb0uy; 0x80uy; 0x6buy; 0x5buy; 0x0euy; 0xc6uy; 0x8auy; 0x21uy; 0xc2uy; 0x25uy; 0xa1uy
            0x4euy; 0x48uy; 0x97uy; 0x02uy; 0x7auy; 0x3fuy; 0x34uy; 0xc0uy; 0x2duy; 0x60uy; 0x1duy; 0x8duy; 0x5auy; 0x15uy; 0x53uy; 0x43uy
            0x3duy; 0xd6uy; 0xa7uy; 0xdduy; 0x02uy; 0x74uy; 0x06uy; 0xaauy; 0xefuy; 0x6auy; 0xfbuy; 0xa7uy; 0x67uy; 0x3duy; 0x97uy; 0xb4uy
            0x60uy; 0x19uy; 0x2duy; 0x4auy; 0x6euy; 0xf4uy; 0xd2uy; 0x97uy; 0x21uy; 0xf0uy; 0x0buy; 0x5auy; 0x21uy; 0x09uy; 0xccuy; 0xb7uy
            0x39uy; 0x00uy; 0xf2uy; 0x8fuy; 0x6euy; 0x53uy; 0xa5uy; 0x43uy; 0xdauy; 0x10uy; 0x45uy; 0xb8uy; 0xeduy; 0x16uy; 0xe8uy; 0x40uy
            0xbbuy; 0x28uy; 0x9fuy; 0xc5uy; 0x95uy; 0xfauy; 0x3cuy; 0xc7uy; 0x15uy; 0x32uy; 0xc4uy; 0x74uy; 0xd6uy; 0x5cuy; 0xbcuy; 0x3buy 
        |]