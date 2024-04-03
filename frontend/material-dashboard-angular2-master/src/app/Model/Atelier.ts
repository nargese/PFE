export class Atelier {
    IdAtelier:string & {isGuid:true};
    NomAtelier:string;
    Labelle:string;
    FK_Filiale:string & {isGuid:true};
}