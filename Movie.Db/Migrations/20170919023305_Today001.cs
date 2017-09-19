using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Movie.Db.Migrations
{
    public partial class Today001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Location_Address_AddressId",
                schema: "Movie",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_VirtualAddress_VirtualAddressId",
                schema: "Movie",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_Location_LocationId",
                schema: "Movie",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_Movies_MovieId",
                schema: "Movie",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_Person_PersonId",
                schema: "Movie",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Media_Users_UserId",
                schema: "Movie",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Address_AddressId",
                schema: "Movie",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Person_PersonId",
                schema: "Movie",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                schema: "Movie",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Media",
                schema: "Movie",
                table: "Media");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                schema: "Movie",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "Movie",
                newName: "Persons");

            migrationBuilder.RenameTable(
                name: "Media",
                schema: "Movie",
                newName: "Medias");

            migrationBuilder.RenameTable(
                name: "Location",
                schema: "Movie",
                newName: "Locations");

            migrationBuilder.RenameIndex(
                name: "IX_Person_AddressId",
                schema: "Movie",
                table: "Persons",
                newName: "IX_Persons_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Media_UserId",
                schema: "Movie",
                table: "Medias",
                newName: "IX_Medias_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Media_PersonId",
                schema: "Movie",
                table: "Medias",
                newName: "IX_Medias_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Media_MovieId",
                schema: "Movie",
                table: "Medias",
                newName: "IX_Medias_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Media_LocationId",
                schema: "Movie",
                table: "Medias",
                newName: "IX_Medias_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_VirtualAddressId",
                schema: "Movie",
                table: "Locations",
                newName: "IX_Locations_VirtualAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Location_AddressId",
                schema: "Movie",
                table: "Locations",
                newName: "IX_Locations_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                schema: "Movie",
                table: "Persons",
                column: "PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medias",
                schema: "Movie",
                table: "Medias",
                column: "MediaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                schema: "Movie",
                table: "Locations",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Address_AddressId",
                schema: "Movie",
                table: "Locations",
                column: "AddressId",
                principalSchema: "Movie",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_VirtualAddress_VirtualAddressId",
                schema: "Movie",
                table: "Locations",
                column: "VirtualAddressId",
                principalSchema: "Movie",
                principalTable: "VirtualAddress",
                principalColumn: "VirtualAddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Locations_LocationId",
                schema: "Movie",
                table: "Medias",
                column: "LocationId",
                principalSchema: "Movie",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Movies_MovieId",
                schema: "Movie",
                table: "Medias",
                column: "MovieId",
                principalSchema: "Movie",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Persons_PersonId",
                schema: "Movie",
                table: "Medias",
                column: "PersonId",
                principalSchema: "Movie",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Users_UserId",
                schema: "Movie",
                table: "Medias",
                column: "UserId",
                principalSchema: "Movie",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Address_AddressId",
                schema: "Movie",
                table: "Persons",
                column: "AddressId",
                principalSchema: "Movie",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_PersonId",
                schema: "Movie",
                table: "Users",
                column: "PersonId",
                principalSchema: "Movie",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Address_AddressId",
                schema: "Movie",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_VirtualAddress_VirtualAddressId",
                schema: "Movie",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Locations_LocationId",
                schema: "Movie",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Movies_MovieId",
                schema: "Movie",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Persons_PersonId",
                schema: "Movie",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Users_UserId",
                schema: "Movie",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Address_AddressId",
                schema: "Movie",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_PersonId",
                schema: "Movie",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                schema: "Movie",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medias",
                schema: "Movie",
                table: "Medias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                schema: "Movie",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Persons",
                schema: "Movie",
                newName: "Person");

            migrationBuilder.RenameTable(
                name: "Medias",
                schema: "Movie",
                newName: "Media");

            migrationBuilder.RenameTable(
                name: "Locations",
                schema: "Movie",
                newName: "Location");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_AddressId",
                schema: "Movie",
                table: "Person",
                newName: "IX_Person_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_UserId",
                schema: "Movie",
                table: "Media",
                newName: "IX_Media_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_PersonId",
                schema: "Movie",
                table: "Media",
                newName: "IX_Media_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_MovieId",
                schema: "Movie",
                table: "Media",
                newName: "IX_Media_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_LocationId",
                schema: "Movie",
                table: "Media",
                newName: "IX_Media_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_VirtualAddressId",
                schema: "Movie",
                table: "Location",
                newName: "IX_Location_VirtualAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Locations_AddressId",
                schema: "Movie",
                table: "Location",
                newName: "IX_Location_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                schema: "Movie",
                table: "Person",
                column: "PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Media",
                schema: "Movie",
                table: "Media",
                column: "MediaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                schema: "Movie",
                table: "Location",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Location_Address_AddressId",
                schema: "Movie",
                table: "Location",
                column: "AddressId",
                principalSchema: "Movie",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_VirtualAddress_VirtualAddressId",
                schema: "Movie",
                table: "Location",
                column: "VirtualAddressId",
                principalSchema: "Movie",
                principalTable: "VirtualAddress",
                principalColumn: "VirtualAddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Location_LocationId",
                schema: "Movie",
                table: "Media",
                column: "LocationId",
                principalSchema: "Movie",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Movies_MovieId",
                schema: "Movie",
                table: "Media",
                column: "MovieId",
                principalSchema: "Movie",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Person_PersonId",
                schema: "Movie",
                table: "Media",
                column: "PersonId",
                principalSchema: "Movie",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Users_UserId",
                schema: "Movie",
                table: "Media",
                column: "UserId",
                principalSchema: "Movie",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Address_AddressId",
                schema: "Movie",
                table: "Person",
                column: "AddressId",
                principalSchema: "Movie",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Person_PersonId",
                schema: "Movie",
                table: "Users",
                column: "PersonId",
                principalSchema: "Movie",
                principalTable: "Person",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
