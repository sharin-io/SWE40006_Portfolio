<?php
$studentName   = "Shin Thant Thi Ri";
$studentId     = "104842811";
$unitCode      = "SWE40006";
$unitName      = "Software Deployment and Evolution";
$serverTimeUtc = gmdate("Y-m-d H:i:s \U\T\C");
$phpVersion    = phpversion();
$hostOS        = php_uname('s');
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Task 3.3 - PHP Cloud Deployment</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <style>
        .tracking-wider { letter-spacing: 0.05em; }
    </style>
</head>
<body class="bg-light">
    <div class="container my-5">
        <div class="row justify-content-center">
            <div class="col-lg-10"> 

                <div class="border-bottom pb-3 mb-4">
                    <h1 class="h3 fw-bold text-dark mb-1">SWE40006: Software Deployment and Evolution</h1>
                    <p class="text-muted mb-0">Task 3.3 - PHP Web Application (HD Level)</p>
                </div>

                <div class="row g-4 text-dark">
                    <div class="col-md-3 col-sm-6">
                        <span class="d-block text-muted small text-uppercase tracking-wider">Student Name</span>
                        <span class="fw-bold"><?= htmlspecialchars($studentName); ?></span>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <span class="d-block text-muted small text-uppercase tracking-wider">Student ID</span>
                        <span class="fw-bold"><?= htmlspecialchars($studentId); ?></span>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <span class="d-block text-muted small text-uppercase tracking-wider">Unit Code</span>
                        <span class="fw-bold"><?= htmlspecialchars($unitCode); ?></span>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <span class="d-block text-muted small text-uppercase tracking-wider">Unit Name</span>
                        <span class="fw-bold"><?= htmlspecialchars($unitName); ?></span>
                    </div>

                    <div class="col-md-3 col-sm-6">
                        <span class="d-block text-muted small text-uppercase tracking-wider">Server Time (UTC)</span>
                        <span class="fw-bold"><?= htmlspecialchars($serverTimeUtc); ?></span>
                    </div>
                    <div class="col-md-3 col-sm-6">
                        <span class="d-block text-muted small text-uppercase tracking-wider">PHP Version</span>
                        <span class="fw-bold"><?= htmlspecialchars($phpVersion); ?></span>
                    </div>
          
                    <div class="col-md-3 col-sm-6">
                        <span class="d-block text-muted small text-uppercase tracking-wider">Operating System</span>
                        <span class="fw-bold"><?= htmlspecialchars($hostOS); ?></span>
                    </div>

                </div>

            </div>
        </div>
    </div>
</body>
</html>
