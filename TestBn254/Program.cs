// See https://aka.ms/new-console-template for more information


using Bn254.Net;

var x1 = new UInt256("2bd3e6d0f3b142924f5ca7b49ce5b9d54c4703d7ae5648e61d02268b1a0a9fb7");
var y1 = new UInt256("21611ce0a6af85915e2f1d70300909ce2e49dfad4a4619c8390cae66cefdb204");
var s = new UInt256("00000000000000000000000000000000000000000000000011138ce750fa15c2");
var xExpected = new UInt256("070a8d6a982153cae4be29d434e8faef8a47b274a053f5a4ee2a6c9c13c31e5c");
var yExpected = new UInt256("031b8ce914eba3a9ffb989f9cdd5b0f01943074bf4f0f315690ec3cec6981afc");

var (x, y) = Bn254.Net.Bn254.Mul(x1, y1, s);

Console.WriteLine($"x: {x}\ny: {y}");