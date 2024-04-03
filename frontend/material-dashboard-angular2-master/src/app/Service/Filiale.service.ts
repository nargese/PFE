import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { FormBuilder, Validators } from "@angular/forms";
import { Filiale } from "app/Model/Filiale";
import { environment } from "environments/environment";

@Injectable({
    providedIn: 'root'
  })
  export class FilialeService {
  
    constructor(private fb :FormBuilder,private http:HttpClient) { }
  
    ListeFiliales:Filiale[]= new Array();
  
    formFiliales=this.fb.group({
      IdFiliale:['00000000-0000-0000-0000-000000000000'],
      Labelle:['', [Validators.required]],
    });
    refreshListFiliales(){
   
      return this.http.get(environment.apiURL + '/Filiales')
      }
  
    postFiliales(){
        return this.http.post(environment.apiURL + '/Filiales', this.formFiliales.value,{ responseType: "text" });
      }
  
      updateFiliales(IdFiliale){
        return this.http.put(environment.apiURL + '/Filiales', this.formFiliales.value,{ responseType: "text" });
  
      }
  
      deleteFiliales(idFiliale){
        return this.http.delete(environment.apiURL + '/Filiales/' + idFiliale, { responseType: "text" })
      }

      resetFilialeForm(){
        this.formFiliales.reset({
          IdFiliale:'00000000-0000-0000-0000-000000000000',
          Labelle:'',
        });
      }
  }