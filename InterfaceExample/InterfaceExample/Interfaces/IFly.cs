
namespace InterfaceExample.Interfaces
{
    internal interface IFly
    {
        int FlySpeed { get; set; }

        void Fly();
    }
}

//object yarada bilmir
//ctor olmur
//field olmur
//default access modifiers for members:public
//default access: public
//interface methodlarinin body-i olmur
//bastract daha performanslidir