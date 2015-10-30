# Nerdle.AutoConfig.Ninject


```csharp
class MyModule : NinjectModule
{
    public override void Load()
    {
        // Load IMyConfigurationObject from AutoConfig section
        Bind<IMyConfigurationObject>().ToConfig();
    }
}
```
