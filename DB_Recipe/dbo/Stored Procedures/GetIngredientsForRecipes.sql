-- =============================================
-- Author:		John Anderson
-- Create date: 3/25/2020
-- Description:	GetIngredientsForSelectedRecipes
-- =============================================
CREATE PROCEDURE GetIngredientsForRecipes 
	-- Add the parameters for the stored procedure here
	@recipelist varchar(200) = 0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select r.id, r.name As Recipe, rc.Name as Chef, r.Stars, r.PrepTime, r.Servings, rt.Name As Type, r.Reference 
from Recipe r
join RecipeChef rc on (r.RecipeChefId = rc.Id)
join RecipeType rt on (r.RecipeTypeId = rt.Id)
Where r.Id in (1,2)

select r.Id As RecipeId, i.Id As IngredientId,  ri.Quantity As Quantity, ri.Size, ri.Unit, i.Name As Item, ic.Name As Category
from Recipe r
left join RecipeIngredient ri on (r.id = ri.RecipeId)
left join Ingredient i on (ri.IngredientId = i.Id)
inner join IngredientCategory ic on (i.CategoryId = ic.Id)
where r.Id in (1,2)
Order By ic.Name
END