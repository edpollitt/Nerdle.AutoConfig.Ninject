# Nerdle.AutoConfig.Ninject

Simple Ninject binding extension for [Nerdle.AutoConfig](https://github.com/edpollitt/Nerdle.AutoConfig)

```csharp
class MyModule : NinjectModule
{
    public override void Load()
    {
        // Load IMyConfigurationObject from AutoConfig section
        Bind<IMyConfigurationObject>().ToConfig().InSingletonScope();
    }
}
```
