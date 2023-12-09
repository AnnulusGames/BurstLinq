# BurstLinq
 Extremely fast LINQ aggregation operations implementation optimized by Burst Compiler

<img src="https://github.com/AnnulusGames/BurstLinq/blob/main/Assets/BurstLinq/Documentation~/img1.png" width="800">

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

[English README is here](README.md)

## 概要

BurstLinqはUnityのBurst Compilerを用いてLINQの集約操作(`Sum`、`Average`、`Min`, etc..)を高速化するライブラリです。BurstLinqを導入することで、Burstが適用可能なLINQメソッドに対して自動的に最適化された実装が適用されるようになり、通常のLINQと比較して遥かに高いパフォーマンスを実現します。

また、`NativeArray<T>`や`Span<T>`など本来LINQが使用できないコレクション型に対して`Sum`、`Min`などのオペレータを追加するほか、`Vector3`、`float3`などのUnity独自の型に対する`Sum`、`Average`もサポートします。

> BurstLinqのコンセプトは[Cysharp/SimdLinq](https://github.com/Cysharp/SimdLinq)にインスパイアされており、こちらは.NETのSIMD APIの代わりにBurstを利用した、Unityに最適化された実装になっています。

## セットアップ

### 要件

* Unity 2021.3 以上
* Burst 1.6.0 以上

### インストール

1. Window > Package ManagerからPackage Managerを開く
2. 「+」ボタン > Add package from git URL
3. 以下のURLを入力する

```
https://github.com/AnnulusGames/BurstLinq.git?path=/Assets/BurstLinq
```

あるいはPackages/manifest.jsonを開き、dependenciesブロックに以下を追記

```json
{
    "dependencies": {
        "com.annulusgames.burst-linq": "https://github.com/AnnulusGames/BurstLinq.git?path=/Assets/BurstLinq"
    }
}
```

## Quick Start

BurstLinqはSimdLinqと同様'Drop-in replacement'となるように設計されており、`using BurstLinq;`を含めるだけでBurstが適用可能な全てのオペレータに対して自動的にBurstLinqのメソッドを適用します。

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

## サポートする型とオペレータ

BurstLinqが対応するオペレータと型の一覧は以下の通りです。

### サポートするコレクション型

* `T[]`
* `List<T>`
* `Memory<T>`
* `ReadOnlyMemory<T>`
* `Span<T>`
* `ReadOnlySpan<T>`
* `NativeArray<T>`
* `NativeList<T>`
* `NativeSlice<T>`

### サポートするオペレータ

* Sum (`int`, `uint`, `long`, `ulong`, `float`, `double`, `Vector2`, `Vector3`, `Vector4`, `int2..4`, `uint2..4`, `float2..4`, `double2..4`)
* Average (`int`, `uint`, `long`, `ulong`, `float`, `double`, `Vector2`, `Vector3`, `Vector4`, `int2..4`, `uint2..4`, `float2..4`, `double2..4`)
* Min (`byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`)
* Max (`byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`)
* Contains (`byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `Vector2`, `Vector3`, `Vector4`, `int2..4`, `uint2..4`, `float2..4`, `double2..4`)
* SequenceEqual (`byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `float`, `double`, `Vector2`, `Vector3`, `Vector4`, `int2..4`, `uint2..4`, `float2..4`, `double2..4`)

## LINQとの互換性

BurstLinqはパフォーマンスの高さを優先するため、LINQと比べて挙動が異なる場合があります。使用する際は以下の違いに注意してください。

### Sum/Average

LINQのSumは`checked`ですが、BurstLinqは`unchecked`です。Burstはオーバーフローの検知をサポートしないため、Burstが無効化された際に動作の違いが生じないように`unchecked`としています。

### 浮動小数点型の扱い

BurstLinqのSumは`[BurstCompile(FloatMode = FloatMode.Fast)]`を指定するため、通常のLINQのSumと比較して計算結果に僅かな誤差が生じます。これが問題になることは稀ですが、互換性がないことには留意してください。

またBurstLinqはfloat/doubleに対するNaNのチェックを行わないため、その点にも注意してください。

## ライセンス

[MIT License](LICENSE)