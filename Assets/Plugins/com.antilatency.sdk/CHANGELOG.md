# Changelog

<!--
Copyright (c) 2020-2022, Meta View, Inc. d/b/a Campfire

All rights reserved.
SPDX-License-Identifier: LicenseRef-Campfire

-->
<!-- markdownlint-disable blanks-around-headings no-duplicate-heading blanks-around-lists-->
All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to
[Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [3.5.0+modified1]
### Changed
- Re-applied Campfire modifications:
  - in `Antilatency.Integration.AltEnvironmentMarkersDrawer`: changed
    `markerSegmentCount` from 8 to 16 in `GenerateMarkerMesh()` (modification
    found in Client project)
  - in `Antilatency.Integration.AltTracking`: change `_trackingCotask` from
    private to protected (so we can share it with native code)
  - in `Antilatency.Alt.Tracking.Constants`: change
    `DefaultAngularVelocityAvgTime` from 0.016 to 0.004 (preferred value found
    by testing)

## [3.5.0]

Updated upstream version. Noted changes, in addition to reorganization of file
structure:

- Unity namespace and assembly name changed from `Antilatency.Integration` to
  `Antilatency.SDK`
- Environment-related classes moved from `Antilatency.Alt.Tracking` to
  `Antilatency.Alt.Environment`

## [2.1.0+modified1]
### Changed
- Applied Campfire modifications:
  - in `Antilatency.Integration.AltEnvironmentMarkersDrawer`: changed
    `markerSegmentCount` from 8 to 16 in `GenerateMarkerMesh()` (modification
    found in Client project)
  - in `Antilatency.Integration.AltTracking`: change `_trackingCotask` from
    private to protected (so we can share it with native code)
  - in `Antilatency.Alt.Tracking.Constants`: change
    `DefaultAngularVelocityAvgTime` from 0.016 to 0.004 (preferred value found
    by testing)

## [2.1.0]
### Added
- Initial artifacts provided by ALT.
