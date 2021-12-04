---
title: Dicom Store
sort_rank: 1
---

# Dicom Store

DICOM Store allows you to:

* Achieve portability and flexibility when accessing DICOM Studies
* Employ a scalable solution
* Avoid data loss with robust disaster recovery and backup solution
* Engage in rigorous analysis to derive intelligent outcomes

DICOM Store is a key enabler for solutions and applications that use DICOM imaging data such as:

* Cloud-enabled workflows
* Bi-directional connectivity to existing on-premise DICOM systems
* Basic and advanced viewing applications
* Image analytics in the cloud
* Integrate with Hospital EMR systems for acces to patient data

**Philips DICOM Store service, part of Philips HealthSuite digital platform (HSDP), provides a secure, scalable, and interoperable cloud-based multi-tenant DICOM storage infrastructure. The service is supported with a standardsbased API OAuth2 and DICOM webTM, or classic DICOM which developers can use to build client applications and system integrations. This versatile store/query/retrieve solution expands access to imaging studies for an improved workflow experience.**

## Multifaceted functionality

DICOM Store is seamlessly integrated with HSDP’s Identity and Access Management (IAM), Clinical Data Repository (CDR), and Auditing and Logging Services to enable secure and compliant clinical workflows.
IAM provides DICOM Store with secure, centralized mechanisms to manage users, services and devices.
The cloud based program features practical and configurable protection capabilities, such as policy-based authentication and authorization, and role-based access control.
Unique metadata is part of every DICOM image and is used to process and manage that image. While the image itself is stored in DICOM Store, the metadata is parsed and registered to the CDR. The registration within the CDR creates a longitudinal view of the Patient Records along with imaging. Multi-tenancy capabilities within CDR assures that the data from different organizations is stored separately and securely with user authorization

## Access control

DICOM Store integrates with Authorize, an IAM capability to provide Organization-Based Access Control (OBAC). Access to the DICOM Study is protected by a set of access control permissions that allow access based on the role of the logged-in user.

## Integrated auditing, logging and monitoring

Host Auditing & Logging provides centralized management for oversight of event activity, system performance, and bugs/errors. Monitoring services display (via a dashboard) the rate at which the service is run – the number of times the system is queried, the number of times an image is retrieved, and more.

## DICOM Transactions

The DICOM Store service supports RESTful web services specified in the DICOM PS3.18 - Web Services standard (commonly referred to as DICOMWeb) and classic services
specified in the DICOM PS3.4 - Service Class Specifications.
The supported transactions/services are:

* Store Transaction - Store DICOM objects (STOW-RS) / C-Store
* Search Transaction - Search for DICOM objects (QIDO-RS) / C-Find
* Retrieve Transaction - Retrieve DICOM objects (WADO-RS) / C-Move

DICOM Store also provides

* Centralized Configuration for managing the Cloud & Gateway services
* Delete and Merge services to enable data management
* Import and Export services to enable data routing

## Connectivity options

Acquisition modality devices and workstations can transfer images directly to DICOM Store via the DICOMWeb or classic DICOM interfaces. Alternatively, images can be forwarded to the DICOM Store in the cloud via the DICOM Gateway.

[![DICOM Connectivity](/assets/DicomStore.png)](/assets/DicomStore.png)

## Multi-tenancy

Multi-tenancy securely segments user and image access through Object-Based-Access Control (OBAC), where the client can segregate resources by the organization and the users can access the appropriate organization.

## Security and privacy

A core strength of HSDP, security is managed by integrating S3 Credentials Service into the DICOM Store to provide control and limit access to S3 buckets. In addition, whether
its HIPAA in the US, ASIST in France, or GDPR in the EU, compliance validation is a crucial factor in HSDP’s comprehensive approach to privacy

## Encryption

Encryption is provided by using platform approved data storage services such as FHIR Store (HSDP CDR) and Object
Store, with defined encryption policies.

## Supported profiles

Philips architects have carefully chosen to include the most commonly used sub-class image profiles. DICOM Store Service supports SOP classes for Generic Radiology,Mammography, Cardiology, Oncology, Ophthalmology and
Pathology profiles. Future releases will add to this list.

