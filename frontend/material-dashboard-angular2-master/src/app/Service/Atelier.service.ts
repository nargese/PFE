import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { environment } from "environments/environment";
import { Atelier } from '../Model/Atelier';

@Injectable({
  providedIn: 'root'
})
export class AtelierService {

  constructor(private fb :FormBuilder,private http:HttpClient) { }

  ListAtelier:Atelier[]= new Array();
  ListAtelierBySubsidiary:Atelier[]= new Array();

  formAtelier=this.fb.group({
    IdAtelier:['00000000-0000-0000-0000-000000000000'],
    Labelle:['', [Validators.required]],
    FK_Filiale:['00000000-0000-0000-0000-000000000000', [Validators.required]]

  });

    refreshListAtelier(){
 
    return this.http.get(environment.apiURL + '/Atelier')
    }

    postAtelier(){
      return this.http.post(environment.apiURL + '/Atelier', this.formAtelier.value,{ responseType: "text" });
    }

    updateAtelier(){
      return this.http.put(environment.apiURL + '/Atelier', this.formAtelier.value,{ responseType: "text" });

    }

    deleteAtelier(IdAtelier){
      return this.http.delete(environment.apiURL + '/Atelier' + IdAtelier, { responseType: "text" })
    }


    resetAtelierForm(){
      this.formAtelier.reset({
        IdAtelier:'00000000-0000-0000-0000-000000000000',
        Labelle:'',
        FK_Filiale:'00000000-0000-0000-0000-000000000000'

      });
    }
    
}