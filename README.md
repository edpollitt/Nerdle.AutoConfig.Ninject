# Nerdle.AutoConfig.Ninject


```csharp
class MyModule : NinjectModule
{
    public override void Load()
    {
        // Load IMyConfigurationConfig from AutoConfig section
        Bind<IMyConfigurationObject>().ToConfig();
    }
}
```
