using JetBrains.Annotations;
using Nomnom.CodeGenUtils;
using Nomnom.UnityProjectPatcher.Editor;
using Nomnom.UnityProjectPatcher.Editor.Steps;

namespace Dhkatz.ContentWarningProjectPatcher.Editor.Editor
{
    [UPPatcher("dev.dhkatz.unity-cw-project-patcher")]
    public static class ContentWarningWrapper
    {
        [UsedImplicitly]
        public static void GetSteps(StepPipeline pipeline)
        {
            pipeline.SetInputSystem(InputSystemType.InputSystem_New);
            pipeline.IsUsingAddressables();
            pipeline.InsertAfter<InjectURPAssetsStep>(new ChangeSceneListStep("NewMainMenu"));
            pipeline.InsertAfter<CopyExplicitScriptFolderStep>(
                new StripMethodsStep(
                    nodeInfo => nodeInfo is { indentifier: "get_gameObject" }
                    )
                );
            pipeline.SetGameViewResolution("16:9");
            pipeline.OpenSceneAtEnd("NewMainMenu");
        }
    }
}
