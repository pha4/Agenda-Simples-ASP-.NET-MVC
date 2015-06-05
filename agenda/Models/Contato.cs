using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace agenda.Models
{
    [Table("contatos")]
    public class Contato
    {
       
       [Key]
        public long contatoId { set; get; }


        [Display(Name="Nome Completo")]
        [Required(ErrorMessage="Preechimento Obrigatório!")]
        [DataType(DataType.Text,ErrorMessage="O campo aceita apenas texto.")]
        [StringLength(50, ErrorMessage = "O campo aceita no máximo 50 caracteres!")]
        public string nomeCompleto { get; set; }

        [Display(Name="Endereço")]
        [Required(ErrorMessage = "Preechimento Obrigatório!")]
        [DataType(DataType.Text, ErrorMessage = "O campo aceita apenas texto.")]
        [StringLength(50, ErrorMessage = "O campo aceita no máximo 50 caracteres!")]
        public string endereco { get; set; }

        [Display(Name="Telefone")]        
        [DataType(DataType.PhoneNumber)]
        [StringLength(11, ErrorMessage = "O campo aceita no máximo 11 caracteres! Informe apenas números!")]
        public string telefone { get; set; }        

    }
}