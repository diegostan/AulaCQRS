using FrotaApp.Infrastructure.Shared.Shared;

namespace FrotaApp.Infrastructure.Output.Queries
{
    public class VehicleQueries : BaseQuery
    {
        public QueryModel GetAllVehicle()
        {
            this.Table = Map.GetVehicleTable();
            this.InnerTable = Map.GetVehicleCategoryTable();

            this.Query = $@"
            SELECT 
            V.[ID],
            V.[CL_NAME] AS [Name],
            [CL_COLOR] AS [Color],
            [CL_MODEL_YEAR] AS [ModelYear],
            [CL_CATEGORY_ID] AS [CategoryId],
            [CL_PRICE] AS [Price],
            [CL_TYPE] AS [Type],
            C.CL_NAME AS [CategoryName],
            V.[CL_CREATED_ON] AS [CreatedOn]
            FROM {this.Table} AS V 
            INNER JOIN {this.InnerTable} AS C 
            ON v.[CL_CATEGORY_ID] = C.[ID]
            ";

            return new QueryModel(this.Query, null);
        }

        public QueryModel GetVehicleById(int id)
        {
            this.Table = Map.GetVehicleTable();
            this.InnerTable = Map.GetVehicleCategoryTable();

            this.Query = $@"
            SELECT 
            V.[ID],
            V.[CL_NAME] AS [Name],
            [CL_COLOR] AS [Color],
            [CL_MODEL_YEAR] AS [ModelYear],
            [CL_CATEGORY_ID] AS [CategoryId],
            [CL_PRICE] AS [Price],
            [CL_TYPE] AS [Type],
            C.CL_NAME AS [CategoryName],
            V.[CL_CREATED_ON] AS [CreatedOn]
            FROM [TB_VEHICLE] AS V 
            INNER JOIN [TB_VEHICLE_CATEGORY] AS C 
            ON v.[CL_CATEGORY_ID] = C.[ID]
            WHERE 
            V.ID = @VehicleId
            ";
            this.Parameters = new 
            {
                VehicleId = id
            };

            return new QueryModel(this.Query, this.Parameters);
        }

         public QueryModel GetVehiclesByCategoryId(int categoryId)
        {
            this.Table = Map.GetVehicleTable();
            this.InnerTable = Map.GetVehicleCategoryTable();

            this.Query = $@"
            SELECT 
            V.[ID],
            V.[CL_NAME] AS [Name],
            [CL_COLOR] AS [Color],
            [CL_MODEL_YEAR] AS [ModelYear],
            [CL_CATEGORY_ID] AS [CategoryId],
            [CL_PRICE] AS [Price],
            [CL_TYPE] AS [Type],
            C.CL_NAME AS [CategoryName],
            V.[CL_CREATED_ON] AS [CreatedOn]
            FROM [TB_VEHICLE] AS V 
            INNER JOIN [TB_VEHICLE_CATEGORY] AS C 
            ON v.[CL_CATEGORY_ID] = C.[ID]
            WHERE 
            V.CL_CATEGORY_ID = @CategoryId
            ";
            this.Parameters = new 
            {
                CategoryId = categoryId
            };

            return new QueryModel(this.Query, this.Parameters);
        }
    }
}