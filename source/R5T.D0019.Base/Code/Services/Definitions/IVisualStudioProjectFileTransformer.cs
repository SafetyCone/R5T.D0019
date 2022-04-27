using System;
using System.Threading.Tasks;

using R5T.T0002;
using R5T.T0064;


namespace R5T.D0019
{
    /// <summary>
    /// Working at the <see cref="IVisualStudioProjectFile"/>-level of abstraction, transforms one instance to be equal to the other instance.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileTransformer : IServiceDefinition
    {
        Task CopySourceToDestinationAsync(IVisualStudioProjectFile source, IVisualStudioProjectFile destination);
    }
}
