// Copyright (C) 2015-2025 The Neo Project.
//
// Program.cs file belongs to the neo project and is free
// software distributed under the MIT software license, see the
// accompanying file LICENSE in the main directory of the
// repository or http://www.opensource.org/licenses/mit-license.php
// for more details.
//
// Redistribution and use in source and binary forms with or without
// modifications are permitted.

using BenchmarkDotNet.Running;

namespace Neo.Json.Benchmarks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BenchmarkRunner.Run<Benchmark_JsonDeserialize>();
            //BenchmarkRunner.Run<Benchmark_OrderedDictionary>();
            //BenchmarkRunner.Run<Benchmark_JBoolean>();
            //BenchmarkRunner.Run<Benchmark_JNumber>();
            //BenchmarkRunner.Run<Benchmark_JObject>();
            //BenchmarkRunner.Run<Benchmark_JPath>();
            //BenchmarkRunner.Run<Benchmark_JString>();
            BenchmarkRunner.Run<Benchmark_JsonArray>();
        }
    }
}