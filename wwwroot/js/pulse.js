let selectedTeam = null;

$(document).ready(function () {

    loadTeams();

    loadCategories();

});

function loadTeams() {

    $.get("/api/setup/teams", function (teams) {

        let html = "";

        teams.forEach(team => {

            html += `
                <div class="col-md-3">

                    <button
                        class="btn btn-outline-primary w-100 team-btn"
                        data-id="${team.id}">

                        ${team.emoji}
                        <br/>
                        ${team.teamName}

                    </button>

                </div>
            `;
        });

        $("#teamContainer").html(html);

    });
}
function loadCategories() {

    $.get("/api/setup/categories", function (categories) {

        let html = "";

        categories.forEach(category => {

            html += `
                <div class="col-md-3">

                    <button
                        class="btn btn-outline-dark w-100 category-btn"
                        data-id="${category.id}">

                        ${category.emoji}
                        <br/>

                        ${category.categoryName}

                    </button>

                </div>
            `;
        });

        $("#categoryContainer").html(html);

    });
}

$(document).on(
    "click",
    ".team-btn",
    function () {

        $(".team-btn")
            .removeClass("btn-primary")
            .addClass("btn-outline-primary");

        $(this)
            .removeClass("btn-outline-primary")
            .addClass("btn-primary");

        selectedTeam = $(this).data("id");

        console.log("Selected Team:", selectedTeam);
    });