# Nerdle.AutoConfig.Ninject


````
class ConfigurationModule : NinjectModule
{
    public override void Load()
    {
        Bind<IMyThing>().ToConfig();
    }
}
````
