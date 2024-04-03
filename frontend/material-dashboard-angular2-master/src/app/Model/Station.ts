export class Station {
    IdStation:string & {isGuid:true};
    NomStation: String;
    Code: String;
    Capacite: number;
    TypeStation:String;
    FK_Atelier:string & {isGuid:true};
}