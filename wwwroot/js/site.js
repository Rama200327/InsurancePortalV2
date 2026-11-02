

    document.addEventListener("DOMContentLoaded", () => {

    const sidebar = document.getElementById("sidebar");
    const menuButton = document.getElementById("mobileMenuBtn");
    const overlay = document.getElementById("sidebarOverlay");

    if (!sidebar || !menuButton || !overlay) {
        return;
    }

    menuButton.addEventListener("click", () => {

        sidebar.classList.toggle("open");
        overlay.classList.toggle("show");

    });


    overlay.addEventListener("click", () => {

        sidebar.classList.remove("open");
        overlay.classList.remove("show");

    });

});

<script>

    function goToStep2() {

        document.getElementById("step1").style.display = "none";

    document.getElementById("step2").style.display = "block";

 }

    function calculatePremium() {

        let vehicleValue =
    parseFloat(document.getElementById("vehicleValue").value);

    let premium =
    vehicleValue * 0.03;

    document.getElementById("premium")
    .value = premium.toFixed(2);

}
    if (nationalId.length !== 10) {

        alert("National ID must be 10 digits");

    return;
} 
    function searchPolicies() {

        let keyword =
    document.getElementById("searchBox")
    .value.toLowerCase();

}

    function deletePolicy(id) {

    if (confirm("Are you sure?")) {

        window.location.href =
        "/Motor/Delete/" + id;
    }
}

    function calculateAge() {

        let dob =
    new Date(
    document.getElementById("DateOfBirth").value
    );

    let age =
    new Date().getFullYear()
    - dob.getFullYear();

    document.getElementById("Age").value = age;
}


    < --! Auto Save Draft -->
    localStorage.setItem(
    "PlateNumber",
    plateNumber
    );
    document.getElementById("PlateNumber").value =
    localStorage.getItem("PlateNumber");

</script>