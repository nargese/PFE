import { Component, OnInit } from "@angular/core";
import { Filiale } from "app/Model/Filiale";
import { FilialeService } from "app/Service/Filiale.service";
import Swal from 'sweetalert2'

@Component({
  selector: 'app-list-filiale',
  templateUrl: './list-filiale.component.html',
  styleUrls: ['./list-filiale.component.scss']
})
export class ListFilialeComponent implements OnInit {
  p: number ;
  constructor(public FilialeService:FilialeService) { }

  ngOnInit() {
    this.FilialeService.refreshListFiliales().subscribe(
      res => {
        this.FilialeService.ListeFiliales = res as Filiale[];
      },
      err => {
        console.log(err);
      }
    );
  }
  onAddFilialeModal(){
    this.FilialeService.resetFilialeForm();
    this.FilialeService.formFiliales.enable();
  }

  onUpdateFiliale(item:Filiale){
    this.populateFilialeForm(item);  
    this.FilialeService.formFiliales.enable();

}
populateFilialeForm(Filiale:Filiale){
this.FilialeService.formFiliales.reset({
  IdFiliale:Filiale.idFiliale,
  Labelle:Filiale.labelle,
});
}

onDeleteFiliale(IdFiliale) {
 
  Swal.fire({
    title: 'Etes-vous sûr de vouloir supprimer cette ligne?',
    text: 'Vous ne pourrez pas récupérer cet enregistrement!',
    icon: 'warning',
    showCancelButton: true,
    confirmButtonText: 'oui, supprimer!',
    cancelButtonText: 'Non, laisser'
  }).then((result) => {
    if (result.value) {
      Swal.fire(
        'Supprimé!',
        'Enregistrement supprimé.',
        'success'
      )
      this.FilialeService.deleteFiliales(IdFiliale).subscribe(
        res =>{
          console.log(res);
          this.FilialeService.refreshListFiliales().subscribe(
            res=>{
              console.log(res);
              this.FilialeService.ListeFiliales=res as Filiale[]
            }
          );
        })
    }
    else if (result.dismiss === Swal.DismissReason.cancel) {
      Swal.fire(
        'Annuler',
        'Enregistrement gardé :)',
        'error'
      )
    }
  })
}}