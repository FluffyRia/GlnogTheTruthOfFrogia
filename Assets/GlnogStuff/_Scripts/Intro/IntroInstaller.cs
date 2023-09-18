using Intro;
using Zenject;
using UnityEngine;
public class IntroInstaller : MonoInstaller {

    [SerializeField] private IntroConfig _introConfig;

    public override void InstallBindings() {
        Container.Bind<IntroConfig>().FromInstance(_introConfig);   
    }
}