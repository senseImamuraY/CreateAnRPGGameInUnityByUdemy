using System;

// IEquatableはEqualsメソッドを実装することを保障するためのインターフェース
public struct GridPosition : IEquatable<GridPosition>
{
    public int x;
    public int z;

    public GridPosition(int x, int z)
    {
        this.x = x;
        this.z = z;
    }

    public override bool Equals(object obj)
    {
        // xはオブジェクトのxと同じかテスト
        return obj is GridPosition position &&
                x == position.x &&
                z == position.z;
    }

    public bool Equals(GridPosition other)
    {
        return this == other;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, z);
    }

    // Debug.Logを使うとその時々に応じた（今回は呼び出し先のクラス）クラスのToStringが呼び出される
    // この場合、ToString()をしないと、Debug.Logでx, yの値を見ることができない
    public override string ToString()
    {
        return $"x: {x}; z:{z}";
    }
    // 演算子のオーバロードをしている。この場合、グリッドポジションが引数にきた場合、
    // オーバーロードした関数(通常の==ではなく)が呼ばれる
    // もしかすると、オーバーライドをしているかも

    public static bool operator ==(GridPosition a, GridPosition b)
    {
        return a.x == b.x && a.z == b.z;
    }
    public static bool operator !=(GridPosition a, GridPosition b)
    {
        return !(a == b);
    }
}