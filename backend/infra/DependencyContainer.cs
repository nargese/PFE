using DATA.Context;
using Domain.Handlers;
using Domain.Models;
using Domain.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OsmoseInverse.Data.Repository;
using OsmoseInverse.Domain.Commands;
using OsmoseInverse.Domain.Handler;
using OsmoseInverse.Domain.Interfaces;
using OsmoseInverse.Domain.Queries;
using OsmoseProject.Models;
using System;
using System.Collections.Generic;

namespace OsmoseInverse.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<OsmoseInverseContext>();



            #region Station

            services.AddTransient<IRepository<Station>, Repository<Station>>();

            services.AddTransient<IRequestHandler<PostGeneric<Station>, string>, AddGenericHandlers<Station>>();
            services.AddTransient<IRequestHandler<PutGeneric<Station>, string>, PutGenericHandlers<Station>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<Station>, string>, DeleteGenericHandlers<Station>>();
            services.AddTransient<IRequestHandler<DeleteObject<Station>, string>, DeleteObjectHandler<Station>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<Station>, IEnumerable<Station>>, GetAllGenericHandlers<Station>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<Station>, Station>, GetGenericHandlerById<Station>>();

            #endregion

            #region Workshop

            services.AddTransient<IRepository<Atelier>, Repository<Atelier>>();

            services.AddTransient<IRequestHandler<PostGeneric<Atelier>, string>, AddGenericHandlers<Atelier>>();
            services.AddTransient<IRequestHandler<PutGeneric<Atelier>, string>, PutGenericHandlers<Atelier>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<Atelier>, string>, DeleteGenericHandlers<Atelier>>();
            services.AddTransient<IRequestHandler<DeleteObject<Atelier>, string>, DeleteObjectHandler<Atelier>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<Atelier>, IEnumerable<Atelier>>, GetAllGenericHandlers<Atelier>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<Atelier>, Atelier>, GetGenericHandlerById<Atelier>>();

            #endregion
            #region Filiale

            services.AddTransient<IRepository<Filiale>, Repository<Filiale>>();

            services.AddTransient<IRequestHandler<PostGeneric<Filiale>, string>, AddGenericHandlers<Filiale>>();
            services.AddTransient<IRequestHandler<PutGeneric<Filiale>, string>, PutGenericHandlers<Filiale>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<Filiale>, string>, DeleteGenericHandlers<Filiale>>();
            services.AddTransient<IRequestHandler<DeleteObject<Filiale>, string>, DeleteObjectHandler<Filiale>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<Filiale>, IEnumerable<Filiale>>, GetAllGenericHandlers<Filiale>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<Filiale>, Filiale>, GetGenericHandlerById<Filiale>>();

            #endregion
            #region ProduitChimique

            services.AddTransient<IRepository<ProduitChimique>, Repository<ProduitChimique>>();

            services.AddTransient<IRequestHandler<PostGeneric<ProduitChimique>, string>, AddGenericHandlers<ProduitChimique>>();
            services.AddTransient<IRequestHandler<PutGeneric<ProduitChimique>, string>, PutGenericHandlers<ProduitChimique>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<ProduitChimique>, string>, DeleteGenericHandlers<ProduitChimique>>();
            services.AddTransient<IRequestHandler<DeleteObject<ProduitChimique>, string>, DeleteObjectHandler<ProduitChimique>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<ProduitChimique>, IEnumerable<ProduitChimique>>, GetAllGenericHandlers<ProduitChimique>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<ProduitChimique>, ProduitChimique>, GetGenericHandlerById<ProduitChimique>>();

            #endregion
            #region CategorieProduitChimique

            services.AddTransient<IRepository<CategorieProduitChimique>, Repository<CategorieProduitChimique>>();

            services.AddTransient<IRequestHandler<PostGeneric<CategorieProduitChimique>, string>, AddGenericHandlers<CategorieProduitChimique>>();
            services.AddTransient<IRequestHandler<PutGeneric<CategorieProduitChimique>, string>, PutGenericHandlers<CategorieProduitChimique>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<CategorieProduitChimique>, string>, DeleteGenericHandlers<CategorieProduitChimique>>();
            services.AddTransient<IRequestHandler<DeleteObject<CategorieProduitChimique>, string>, DeleteObjectHandler<CategorieProduitChimique>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<CategorieProduitChimique>, IEnumerable<CategorieProduitChimique>>, GetAllGenericHandlers<CategorieProduitChimique>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<CategorieProduitChimique>, CategorieProduitChimique>, GetGenericHandlerById<CategorieProduitChimique>>();

            #endregion
            #region TypeMembrane

            services.AddTransient<IRepository<TypeMembrane>, Repository<TypeMembrane>>();

            services.AddTransient<IRequestHandler<PostGeneric<TypeMembrane>, string>, AddGenericHandlers<TypeMembrane>>();
            services.AddTransient<IRequestHandler<PutGeneric<TypeMembrane>, string>, PutGenericHandlers<TypeMembrane>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<TypeMembrane>, string>, DeleteGenericHandlers<TypeMembrane>>();
            services.AddTransient<IRequestHandler<DeleteObject<TypeMembrane>, string>, DeleteObjectHandler<TypeMembrane>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<TypeMembrane>, IEnumerable<TypeMembrane>>, GetAllGenericHandlers<TypeMembrane>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<TypeMembrane>, TypeMembrane>, GetGenericHandlerById<TypeMembrane>>();

            #endregion
            #region SourceDeau

            services.AddTransient<IRepository<SourceDeau>, Repository<SourceDeau>>();

            services.AddTransient<IRequestHandler<PostGeneric<SourceDeau>, string>, AddGenericHandlers<SourceDeau>>();
            services.AddTransient<IRequestHandler<PutGeneric<SourceDeau>, string>, PutGenericHandlers<SourceDeau>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<SourceDeau>, string>, DeleteGenericHandlers<SourceDeau>>();
            services.AddTransient<IRequestHandler<DeleteObject<SourceDeau>, string>, DeleteObjectHandler<SourceDeau>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<SourceDeau>, IEnumerable<SourceDeau>>, GetAllGenericHandlers<SourceDeau>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<SourceDeau>, SourceDeau>, GetGenericHandlerById<SourceDeau>>();

            #endregion

            #region Fournisseur

            services.AddTransient<IRepository<Fournisseur>, Repository<Fournisseur>>();

            services.AddTransient<IRequestHandler<PostGeneric<Fournisseur>, string>, AddGenericHandlers<Fournisseur>>();
            services.AddTransient<IRequestHandler<PutGeneric<Fournisseur>, string>, PutGenericHandlers<Fournisseur>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<Fournisseur>, string>, DeleteGenericHandlers<Fournisseur>>();
            services.AddTransient<IRequestHandler<DeleteObject<Fournisseur>, string>, DeleteObjectHandler<Fournisseur>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<Fournisseur>, IEnumerable<Fournisseur>>, GetAllGenericHandlers<Fournisseur>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<Fournisseur>, Fournisseur>, GetGenericHandlerById<Fournisseur>>();

            #endregion
            #region TypeCartouche

            services.AddTransient<IRepository<TypeCartouche>, Repository<TypeCartouche>>();

            services.AddTransient<IRequestHandler<PostGeneric<TypeCartouche>, string>, AddGenericHandlers<TypeCartouche>>();
            services.AddTransient<IRequestHandler<PutGeneric<TypeCartouche>, string>, PutGenericHandlers<TypeCartouche>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<TypeCartouche>, string>, DeleteGenericHandlers<TypeCartouche>>();
            services.AddTransient<IRequestHandler<DeleteObject<TypeCartouche>, string>, DeleteObjectHandler<TypeCartouche>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<TypeCartouche>, IEnumerable<TypeCartouche>>, GetAllGenericHandlers<TypeCartouche>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<TypeCartouche>, TypeCartouche>, GetGenericHandlerById<TypeCartouche>>();

            #endregion
            #region Puit

            services.AddTransient<IRepository<Puit>, Repository<Puit>>();

            services.AddTransient<IRequestHandler<PostGeneric<Puit>, string>, AddGenericHandlers<Puit>>();
            services.AddTransient<IRequestHandler<PutGeneric<Puit>, string>, PutGenericHandlers<Puit>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<Puit>, string>, DeleteGenericHandlers<Puit>>();
            services.AddTransient<IRequestHandler<DeleteObject<Puit>, string>, DeleteObjectHandler<Puit>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<Puit>, IEnumerable<Puit>>, GetAllGenericHandlers<Puit>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<Puit>, Puit>, GetGenericHandlerById<Puit>>();

            #endregion

            #region Bassin

            services.AddTransient<IRepository<Bassin>, Repository<Bassin>>();

            services.AddTransient<IRequestHandler<PostGeneric<Bassin>, string>, AddGenericHandlers<Bassin>>();
            services.AddTransient<IRequestHandler<PutGeneric<Bassin>, string>, PutGenericHandlers<Bassin>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<Bassin>, string>, DeleteGenericHandlers<Bassin>>();
            services.AddTransient<IRequestHandler<DeleteObject<Bassin>, string>, DeleteObjectHandler<Bassin>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<Bassin>, IEnumerable<Bassin>>, GetAllGenericHandlers<Bassin>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<Bassin>, Bassin>, GetGenericHandlerById<Bassin>>();

            #endregion

            #region Compte

            services.AddTransient<IRepository<Compte>, Repository<Compte>>();

            services.AddTransient<IRequestHandler<PostGeneric<Compte>, string>, AddGenericHandlers<Compte>>();
            services.AddTransient<IRequestHandler<PutGeneric<Compte>, string>, PutGenericHandlers<Compte>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<Compte>, string>, DeleteGenericHandlers<Compte>>();
            services.AddTransient<IRequestHandler<DeleteObject<Compte>, string>, DeleteObjectHandler<Compte>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<Compte>, IEnumerable<Compte>>, GetAllGenericHandlers<Compte>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<Compte>, Compte>, GetGenericHandlerById<Compte>>();

            #endregion

            #region Login

            services.AddTransient<IRepository<Login>, Repository<Login>>();

            services.AddTransient<IRequestHandler<PostGeneric<Login>, string>, AddGenericHandlers<Login>>();
            services.AddTransient<IRequestHandler<PutGeneric<Login>, string>, PutGenericHandlers<Login>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<Login>, string>, DeleteGenericHandlers<Login>>();
            services.AddTransient<IRequestHandler<DeleteObject<Login>, string>, DeleteObjectHandler<Login>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<Login>, IEnumerable<Login>>, GetAllGenericHandlers<Login>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<Login>, Login>, GetGenericHandlerById<Login>>();

            #endregion

            #region Role

            services.AddTransient<IRepository<Role>, Repository<Role>>();

            services.AddTransient<IRequestHandler<PostGeneric<Role>, string>, AddGenericHandlers<Role>>();
            services.AddTransient<IRequestHandler<PutGeneric<Role>, string>, PutGenericHandlers<Role>>();
            services.AddTransient<IRequestHandler<DeleteGeneric<Role>, string>, DeleteGenericHandlers<Role>>();
            services.AddTransient<IRequestHandler<DeleteObject<Role>, string>, DeleteObjectHandler<Role>>();

            services.AddTransient<IRequestHandler<GetAllGenericQuery<Role>, IEnumerable<Role>>, GetAllGenericHandlers<Role>>();
            services.AddTransient<IRequestHandler<GetGenericQueryById<Role>, Role>, GetGenericHandlerById<Role>>();

            #endregion


            #region Goal



            #endregion

            #region Equipment



            #endregion

            #region StationParameter



            #endregion

            #region TrackingParameter



            #endregion

            #region DailyTrackedItem


            #endregion

            #region ConsumableProduct



            #endregion

            #region MembraneChangement



            #endregion

            #region CartridgeChangement



            #endregion

            #region ChemicalWashing


            #endregion

            #region ChemicalDosage



            #endregion

            #region Maintain



            #endregion

            #region OsmoseMaintain



            #endregion

            #region WellMaintain



            #endregion

            #region WellMaintain



            #endregion

            #region ChekListElement



            #endregion

            #region Supplier



            #endregion

            #region TrackingType



            #endregion

            #region Unite



            #endregion


        }

    }

}
