# Nerdle.AutoConfig.Ninject


````
class MynModule : NinjectModule
{
    public override void Load()
    {
        Bind<IMyThing>().ToConfig();
    }
}
````
