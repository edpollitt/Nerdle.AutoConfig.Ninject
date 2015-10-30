# Nerdle.AutoConfig.Ninject


````
class MyModule : NinjectModule
{
    public override void Load()
    {
        // Load IMyConfigurationConfig from AutoConfig section
        Bind<IMyConfigurationObject>().ToConfig();
    }
}
````
