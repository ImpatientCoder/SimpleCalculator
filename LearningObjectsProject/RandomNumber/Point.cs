class Point
{
    public long Val { get; set; }
    public long Index { get; set; }
    public Point(long value, long index)
    {
        Val = value;
        this.Index = index;
    }
    public static bool ComparePoint(Point a, Point b)
    {
        return (a.Val >= b.Val);
    }
}
