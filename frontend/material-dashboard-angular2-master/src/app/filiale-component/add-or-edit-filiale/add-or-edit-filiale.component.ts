import { Component, OnInit } from "@angular/core";
import { Filiale } from "app/Model/Filiale";
import { FilialeService } from "app/Service/Filiale.service";
import Swal from 'sweetalert2'
@Component({
  selector: 'app-add-or-edit-filiale',
  templateUrl: './add-or-edit-filiale.component.html',
  styleUrls: ['./add-or-edit-filiale.component.scss']
})
export class AddOrEditFilialeComponent implements OnInit {

  constructor(public FilialeService:FilialeService) { }

  ngOnInit() {
  }

  onSubmit(){
    if( this.FilialeService.formFiliales.controls.IdFiliale.value == '00000000-0000-0000-0000-000000000000'){
      this.FilialeService.postFiliales().subscribe(
        res=>{
          console.log(res);
          this.FilialeService.resetFilialeForm();

          Swal.fire({
            position: 'top-end',
            text: 'l\'ajout est effectué avec succès',
            icon: 'success',
            toast: true,
            timer: 3000,
            timerProgressBar: true,
            showConfirmButton: false
          });
          
          this.FilialeService.refreshListFiliales().subscribe(
            res=>{
              console.log(res);
              this.FilialeService.ListeFiliales=res as Filiale[]
            }
          );
        }

      )
    }
    else{

      this.FilialeService.updateFiliales(Filiale).subscribe(
        res=>{
          console.log(res);
          this.FilialeService.formFiliales.disable();

          Swal.fire({
            position: 'top-end',
            text: 'la modification est fait avec succés',
            icon: 'warning',
            toast: true,
            timer: 3000,
            timerProgressBar: true,
            showConfirmButton: false
          });
          this.FilialeService.refreshListFiliales().subscribe(
            res=>{
              console.log(res);
              this.FilialeService.ListeFiliales=res as Filiale[]
            }
          );
        
        }
      )

    }

  }

}
