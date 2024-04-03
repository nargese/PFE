import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { FormBuilder, Validators } from "@angular/forms";
import { Atelier } from "app/Model/Atelier";
import { Station } from "app/Model/Station";
import { environment } from "environments/environment";

@Injectable({
    providedIn: 'root'
  })
  export  class StationService {
  
    constructor(private fb :FormBuilder,private http:HttpClient) { }
    ListAtelier :Atelier[];
    ListStation:Station[];
    ListStationByAtelier:Station[]=new Array();
    formStation=this.fb.group({
      IdStation:['00000000-0000-0000-0000-000000000000'],
      NomStation:['', [Validators.required]],
      Code:['', [Validators.required]],
      Capacite:['', [Validators.required]],
      TypeStation:['', [Validators.required]],
      FK_Atelier:['00000000-0000-0000-0000-000000000000', [Validators.required]],
    });
    refreshListStation(){
   
      return this.http.get(environment.apiURL + '/Station')
      }
  
      postStation(){
        return this.http.post(environment.apiURL + '/Station', this.formStation.value,{ responseType: "text" });
      }
  
      updateStation(){
        return this.http.put(environment.apiURL + '/Station', this.formStation.value,{ responseType: "text" });
  
      }
  
      deleteStation(IdStation){
        return this.http.delete(environment.apiURL + '/Station' + IdStation, { responseType: "text" })
      }
  
      getStattionByAtelier(IdAtelier){
        return this.http.get(environment.apiURL + '/Station' + IdAtelier)
      }
  
      resetStationForm(){
        this.formStation.reset({
          IdStation:'00000000-0000-0000-0000-000000000000',
          NomStation:'',
          Code:'',
          Capacite:'',
          TypeStation:'',
          FK_Atelier:'00000000-0000-0000-0000-000000000000'
  
        });
      }
  
  }