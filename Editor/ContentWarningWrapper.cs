using Nomnom.UnityProjectPatcher.Editor;
using Nomnom.UnityProjectPatcher.Editor.Steps;

namespace Dhkatz.ContentWarningProjectPatcher.Editor.Editor
{
    [UPPatcher("dev.dhkatz.unity-cw-project-patcher")]
    public static class ContentWarningWrapper
    {
        public static void GetSteps(StepPipeline pipeline)
        {
            pipeline.SetInputSystem(InputSystemType.InputSystem_New);
            pipeline.IsUsingAddressables();
            pipeline.SetGameViewResolution("16:9");
            pipeline.OpenSceneAtEnd("NewMainMenu");
        }
    }
}
