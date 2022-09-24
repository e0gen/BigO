namespace BigO.DataStructures.Abstractions
{
    public interface IDisjointSetUnion
    {
        void MakeSet(int x);
        int Find(int x);
        void Union(int x, int y);
    }
}
