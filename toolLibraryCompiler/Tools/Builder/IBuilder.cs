namespace toolLibraryCompiler.Tools.Builder
{
    public interface IBuilder<out TProduct>
    {
        TProduct Build();
    }
}