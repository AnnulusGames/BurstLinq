# BurstLinq
Extremely fast LINQ aggregation operations implementation optimized by Burst Compiler

<img src="https://github.com/AnnulusGames/BurstLinq/blob/main/Assets/BurstLinq/Documentation~/img1.png" width="800">

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

[日本語版READMEはこちら](README_JA.md)

## Overview

BurstLinq is a library designed to accelerate LINQ aggregation operations (`Sum`, `Average`, `Min`, etc.) using Unity's Burst Compiler. By integrating BurstLinq, automatically optimized implementations are applied to LINQ methods eligible for Burst, resulting in significantly higher performance compared to regular LINQ.

Additionally, BurstLinq adds operators like `Sum`, `Min`, etc., to collection types that LINQ cannot usually operate on, such as `NativeArray<T>` or `Span<T>`. It also supports operations like `Sum` and `Average` for Unity-specific types such as `Vector3` and `float3`.

> The concept of BurstLinq is inspired by [Cysharp/SimdLinq](https://github.com/Cysharp/SimdLinq). BurstLinq is a Unity-optimized version that uses Burst instead of .NET's SIMD API.

## Setup

### Requirements

* Unity 2021.3 or later
* Burst 1.6.0 or later

### Installation

1. Open the Package Manager by going to Window > Package Manager.
2. Click on the "+" button and select "Add package from git URL".
3. Enter the following URL:

```
https://github.com/AnnulusGames/BurstLinq.git?path=/Assets/BurstLinq
```

Alternatively, open `Packages/manifest.json` and add the following to the `dependencies` block:

```json
{
    "dependencies": {
        "com.annulusgames.burst-linq": "https://github.com/AnnulusGames/BurstLinq.git?path=/Assets/BurstLinq"
    }
}
```

## Quick Start

BurstLinq is designed as a 'Drop-in replacement' similar to SimdLinq, simply including `using BurstLinq;` will automatically apply BurstLinq methods to all operators eligible for Burst.

```cs
using System.Collections.Generic;
using System.Linq;
using BurstLinq;

var enumerable = Enumerable.Range(0, 100);
var array = enumerable.ToArray();

// Enumerable.Sum()
var linqSum = enumerable.Sum();

// BurstLinqExtensions.Sum()
var burstLinqSum = array.Sum();
```

## Supported Types and Operators

Below is the list of operators and types supported by BurstLinq.

### Supported Collection Types

* `T[]`
* `List<T>`
* `Memory<T>`
* `ReadOnlyMemory<T>`
* `Span<T>`
* `ReadOnlySpan<T>`
* `NativeArray<T>`
* `NativeList<T>`
* `NativeSlice<T>`

### Supported Operators

* Sum (`int`, `uint`, `long`, `ulong`, `float`, `double`, `Vector2`, `Vector3`, `Vector4`, `int2..4`, `uint2..4`, `float2..4`, `double2..4`)
* Average (`int`, `uint`, `long`, `ulong`, `float`, `double`, `Vector2`, `Vector3`, `Vector4`, `int2..4`, `uint2..4`, `float2..4`, `double2..4`)
* Min (`byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`)
* Max (`byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`)
* Contains (`byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `Vector2`, `Vector3`, `Vector4`, `int2..4`, `uint2..4`, `float2..4`, `double2..4`)
* SequenceEqual (`byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `Vector2`, `Vector3`, `Vector4`, `int2..4`, `uint2..4`, `float2..4`, `double2..4`)

## Compatibility with LINQ

BurstLinq may behave differently compared to LINQ as it prioritizes high performance. Be mindful of the following differences when using it.

### Sum/Average

While LINQ's Sum is `checked`, BurstLinq is `unchecked`. Burst does not support overflow detection, hence it is set to `unchecked` to avoid behavioral differences when Burst is disabled.

### Handling of Floating-Point Types

BurstLinq's `Sum` specifies `[BurstCompile(FloatMode = FloatMode.Fast)]`, resulting in slight computational discrepancies compared to regular LINQ's `Sum`. While this is rarely an issue, note the lack of compatibility.

Additionally, BurstLinq does not check for NaN for float/double types, so please take note of this aspect.

## License

[MIT License](LICENSE)